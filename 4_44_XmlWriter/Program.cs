﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _4_44_XmlWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            StringWriter stream = new StringWriter();

            using (XmlWriter writer = XmlWriter.Create(stream, 
                                            new XmlWriterSettings() { Indent = true }))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("People");
                writer.WriteStartElement("Person");
                writer.WriteAttributeString("firstName", "John");
                writer.WriteAttributeString("lastName", "Doe");
                writer.WriteStartElement("ContactDetails");
                writer.WriteElementString("EmailAddress", "john@unknown.com");
                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.Flush();
            }



            Console.WriteLine(stream.ToString());


            string path = @"c:\temp\test.xml";

            using (StreamWriter streamWriter = File.CreateText(path))
            {
                streamWriter.Write(stream.ToString());
            }
        }
    }
}
