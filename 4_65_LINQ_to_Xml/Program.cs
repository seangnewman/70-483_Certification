﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _4_65_LINQ_to_Xml
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

              XDocument doc = XDocument.Parse(xml);

              IEnumerable<string> personNames = from p in doc.Descendants("person")
                                              select (string)p.Attribute("firstname")
                                              + " " + (string)p.Attribute("lastname");

              foreach (var person in personNames)
              {
                Console.WriteLine(person);
              }

            
        }
    }
}
