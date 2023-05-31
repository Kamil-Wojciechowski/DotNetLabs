using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using Zadanie04;

namespace Zadanie05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            createXSD();

            List<Person> list = new List<Person>();
            list.Add(new Person("Mirosław", "Szczesny", 21, 99999900001));
            list.Add(new Person("Kasia", "Łapka", 25, 99999900002));
            list.Add(new Person("Paweł", "Mikser", 31, 99999900003));

            XmlSerializer serializer = new XmlSerializer(typeof(List<Person>));
            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
            namespaces.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");
            namespaces.Add("schemaLocation", "osoby.xsd");

            // Ustawienia pisarza pliku XML
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;

            // Utwórz obiekt XmlWriter z ustawieniami
            using (XmlWriter writer = XmlWriter.Create("osoby.xml", settings))
            {
                // Serializuj listę osób do pliku
                serializer.Serialize(writer, list, namespaces); 
            }
        }

        static void createXSD()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Person));

            XmlSchema schema = new XmlSchema();
            schema.TargetNamespace = "http://www.example.com/Osoba";

            XmlSchemaElement rootElement = new XmlSchemaElement();
            rootElement.Name = "Osoba";
            rootElement.SchemaType = new XmlSchemaComplexType();

            XmlSchemaSequence sequence = new XmlSchemaSequence();

            XmlSchemaElement element = new XmlSchemaElement();
            element.Name = "Imię";
            element.SchemaTypeName = new XmlQualifiedName("string", "http://www.w3.org/2001/XMLSchema");
            sequence.Items.Add(element);

            element = new XmlSchemaElement();
            element.Name = "Nazwisko";
            element.SchemaTypeName = new XmlQualifiedName("string", "http://www.w3.org/2001/XMLSchema");
            sequence.Items.Add(element);

            element = new XmlSchemaElement();
            element.Name = "Wiek";
            element.SchemaTypeName = new XmlQualifiedName("int", "http://www.w3.org/2001/XMLSchema");
            sequence.Items.Add(element);

            element = new XmlSchemaElement();
            element.Name = "Pesel";
            element.SchemaTypeName = new XmlQualifiedName("long", "http://www.w3.org/2001/XMLSchema");
            sequence.Items.Add(element);

            ((XmlSchemaComplexType)rootElement.SchemaType).Particle = sequence;

            schema.Items.Add(rootElement);

            XmlSchemaSet schemaSet = new XmlSchemaSet();
            schemaSet.Add(schema);
            schemaSet.Compile();

            using (FileStream file = new FileStream("osoby.xsd", FileMode.Create))
            {
                schema.Write(file);
            }
        }
    }
}