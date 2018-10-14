using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _4_67_Create_XML
{
    class Program
    {
        static void Main(string[] args)
        {

            XElement root = new XElement("Root", new List<XElement>
            {
                new XElement("Child1"),
                new XElement("Child2"),
                new XElement("Child3")
            },
            new XAttribute("MyAttribute", 42)
            );

            root.Save(@"c:\temp\xmlTest.xml");

        }
    }
}
