using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _4_68_Update_XML_Procedural
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

            foreach (var p in root.Descendants("person"))
            {
                string name = (string)p.Attribute("firstname") + (string)p.Attribute("lastname");
                p.Add(new XAttribute("IsMale", name.Contains("john")));
                XElement contactDetails = p.Element("contactdetails");
                if (!contactDetails.Descendants("phonenumber").Any());
                {
                    contactDetails.Add(new XElement("phonenumber", "001122334455"));
                }
            }

            root.Save(@"c:\temp\xmlTest2.xml");
        }
    }
}
