using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_2_DbContext
{
    class ShopContext : DbContext
    {
        public IDbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Make sure the database knows how to handle the duplicate address 
            // property
            modelBuilder.Entity<Customer>().HasRequired(bm => bm.BillingAddress)
                                    .WithMany()
                                    .WillCascadeOnDelete(false);
        }

    }
}
