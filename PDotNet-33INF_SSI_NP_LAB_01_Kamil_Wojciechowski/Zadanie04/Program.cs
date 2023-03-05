namespace Zadanie04;

internal class Program
{
    private static void Main(string[] args)
    {
        var path = Directory.GetCurrentDirectory();

        if (args.Length >= 1 && !args[0].Equals(null)) path = args[0];

        var files = Directory.GetFiles(path);
        var directories = Directory.GetDirectories(path);

        foreach (var item in files) Console.WriteLine(Path.GetFileName(item + " "));

        foreach (var item in directories) Console.WriteLine(new DirectoryInfo(item + "\\").Name + "\\ ");
    }
}