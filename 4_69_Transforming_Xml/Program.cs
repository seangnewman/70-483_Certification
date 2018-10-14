using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _4_69_Transforming_Xml
{
    class Program
    {
        static void Main(string[] args)
        {

            string xml = @"<?xml version=""1.0"" encoding=""utf-8"" ?>
                          <people>
                            <person firstname=""john"" lastname=""doe"">
                              <contactdetails>
                                <emailaddress>john@unknown.com</emailaddress>
                              </contactdetails>
                            </person>
                            <person firstname=""jane"" lastname=""doe"">
                              <contactdetails>
                                <emailaddress>jane@unknown.com</emailaddress>
                                <phonenumber>001122334455</phonenumber>
                              </contactdetails>
                            </person>
                          </people>";

            XElement root = XElement.Parse(xml);

            XElement newTree = new XElement("people",
                from p in root.Descendants("person")
                let name = (string)p.Attribute("firstname") + (string)p.Attribute("lastname")
                let contactDetails = p.Element("contactdetails")
                    select new XElement("person", 
                                        new XAttribute("IsMale", name.Contains("john")),
                                        p.Attributes(),
                                        new XElement("contactdetails"),
                                            contactDetails.Element("emailaddress"),
                                            contactDetails.Element("phonenumber") ?? new XElement("phonenumber","112233455")));

            root.Save(@"c:\temp\xmlTest3.xml");
        }
    }
}
