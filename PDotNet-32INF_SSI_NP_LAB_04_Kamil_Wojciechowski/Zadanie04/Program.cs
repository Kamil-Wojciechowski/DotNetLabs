using System.Xml.Serialization;

namespace Zadanie04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var osoba = new Person("Kamil", "Wojciechowski", 24, 99010101001);

            var serializer = new XmlSerializer(typeof(Person));

            using (var stream = new StreamWriter("osoba.xml"))
            {
                serializer.Serialize(stream, osoba);
            }

            Console.WriteLine("Dane zostały wstawione do pliku osoba.xml");
        }
    }
}