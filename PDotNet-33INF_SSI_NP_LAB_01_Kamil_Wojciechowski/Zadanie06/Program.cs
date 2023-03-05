using Zadanie06Dll;

namespace Zadanie06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            add dll = new add();

            Console.WriteLine(dll.Add(1, 2));
        }
    }
}