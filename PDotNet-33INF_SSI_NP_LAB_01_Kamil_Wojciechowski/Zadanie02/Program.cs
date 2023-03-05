using System.Globalization;
using System.Text.RegularExpressions;

namespace Zadanie02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo ci = CultureInfo.InstalledUICulture;

            switch (ci.Name)
            {
                case var plLang when new Regex(@"pl.*").IsMatch(plLang):
                    Console.WriteLine("Witaj, świecie!");
                    break;
                case var enLang when new Regex(@"en.*").IsMatch(enLang):
                    Console.WriteLine("Hello, world!");
                    break;
                default:
                    Console.WriteLine("I don't speak your language!");
                    break;
            }
        }
    }
}