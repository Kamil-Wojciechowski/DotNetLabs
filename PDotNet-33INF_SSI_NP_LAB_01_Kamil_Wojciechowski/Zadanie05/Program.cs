namespace Zadanie05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 4)
            {
                File.WriteAllText(args[3], File.ReadAllText(args[2]).Replace(args[0], args[1]));
            }
            else
            {
                Console.WriteLine("Komenda nie pełna: <textTarget> <textReplace> <fileIn> <fileOut>");
            }
        }
    }
}