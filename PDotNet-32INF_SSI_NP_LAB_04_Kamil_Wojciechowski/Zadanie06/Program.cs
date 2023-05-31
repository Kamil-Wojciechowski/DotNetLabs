using System.Xml.Schema;
using System.Xml;

namespace Zadanie06
{
    internal class Program
    {

        private static string validFile = "books.xml";
        private static string notValidFile = "booksNotValid.xml";
        private static string xsdFile = "books.xsd";

        static void Main(string[] args)
        {
            XmlSchemaSet schemas = new XmlSchemaSet();
            schemas.Add("http://www.example.com/catalog", xsdFile);

            XmlReaderSettings settings = new XmlReaderSettings();
            settings.Schemas = schemas;
            settings.ValidationEventHandler += new ValidationEventHandler(ValidationCallBack);
            settings.ValidationType = ValidationType.Schema;

            XmlReader reader = XmlReader.Create(notValidFile, settings);

            XmlDocument document = new XmlDocument();
            document.Load(reader);

            try
            {
                document.Validate(ValidationCallBack);
                Console.WriteLine("XML file is valid.");
            }
            catch (XmlException ex)
            {
                Console.WriteLine("XML file is not valid: " + ex.Message);
            }
        }

        static void ValidationCallBack(object sender, ValidationEventArgs args)
        {
            if (args.Severity == XmlSeverityType.Warning)
                Console.WriteLine("WARNING: " + args.Message);
            else if (args.Severity == XmlSeverityType.Error)
                Console.WriteLine("ERROR: " + args.Message);
        }
    }
}