﻿using System.ComponentModel.DataAnnotations;

namespace _3_2_DbContext
{
    class Customer
    {
        public int Id { get; set; }

        [Required, MaxLength(20)]
        public string FirstName { get; set; }

        [Required, MaxLength(20)]
        public string LastName { get; set; }

        [Required]
        public Address ShippingAddress { get; set; }

        [Required]
        public Address BillingAddress  { get; set; }


    }
}
