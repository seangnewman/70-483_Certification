using System;
using System.Collections.Generic;
using System.Web.Script.Serialization;
using System.Xml;
using System.Xml.Schema;

namespace _3_16_JSON_XML_Validation
{
    class Program
    {
        static void Main(string[] args)
        {
            var serializer = new JavaScriptSerializer();
            string jsonFile = "person.json";

            if (IsJson(jsonFile))
            {
                var result = serializer.Deserialize<Dictionary<string, object>>(jsonFile);
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Invalid JSON Format");
            }
           
        }

        public static bool IsJson(string input)
        {
            input = input.Trim();
            return input.StartsWith("{") && input.EndsWith("}")
                || input.StartsWith("[") && input.EndsWith("]");
        }

        public static void ValidateXml()
        {
            string xsdPath = "person.xsd";
            string xmlPath = "person.xml";

            XmlReader reader = XmlReader.Create(xmlPath);
            XmlDocument document = new XmlDocument();
            document.Schemas.Add("", xsdPath);
            document.Load(reader);

            ValidationEventHandler eventHandler =
                new ValidationEventHandler(ValidationEventHandler);
            document.Validate(eventHandler);
        }

        static void ValidationEventHandler(object sender, ValidationEventArgs e)
        {
            switch (e.Severity)
            {
                case XmlSeverityType.Error:
                    Console.WriteLine("Error: {0}", e.Message);
                    break;
                case XmlSeverityType.Warning:
                    Console.WriteLine("Warning {0}", e.Message);
                    break;
                

            }
        }
    }
}
