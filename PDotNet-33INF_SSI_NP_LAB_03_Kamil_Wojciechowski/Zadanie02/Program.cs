using System.Text.RegularExpressions;

namespace Zadanie02
{
    internal class Program
    {
        private static readonly string ipPattern = @"^(([01]?[0-9]?[0-9]|2[0-4][0-9]|25[0-5])\.){3}([01]?[0-9]?[0-9]|2[0-4][0-9]|25[0-5])$";
        private static readonly string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj typ: (IP/Email)");
            string input = Console.ReadLine();

            if (input.Equals("IP"))
            {
                Console.WriteLine("Podaj Adres IP (XXX.XXX.XXX.XXX) ");
                input = Console.ReadLine();

                if (Regex.IsMatch(input, ipPattern))
                {
                    Console.WriteLine("IP Adres jest poprawny!");
                }
                else
                {
                    Console.WriteLine("IP Adres jest niepoprawny!");
                }

            } else if (input.Equals("Email"))
            {
                Console.WriteLine("Podaj Adres EMail (example@example.com) ");
                input = Console.ReadLine();

                if (Regex.IsMatch(input, emailPattern))
                {
                    Console.WriteLine("Adres Email jest poprawny!");
                }
                else
                {
                    Console.WriteLine("Adres Email jest niepoprawny!");
                }
            }
            else
            {
                Console.WriteLine("Błędny typ!");
            }
        }
    }
}