namespace Zadanie07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CollectionTest ct = new CollectionTest(new[] { 1, 2, 3, 4, 5 });

            foreach (var c in ct)
            {
                Console.WriteLine(c.ToString());
            }
        }
    }
}