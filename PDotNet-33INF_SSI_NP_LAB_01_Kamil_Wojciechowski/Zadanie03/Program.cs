namespace Zadanie03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj! Podane parametry to:");

            foreach (var param in args)
            {
                Console.WriteLine(param);
            }

            Console.WriteLine("Parametry środowiskowe: ");

            foreach (var item in Environment.GetEnvironmentVariables())
            {
                Console.WriteLine(item.ToString());
            }

            
        }
    }
}