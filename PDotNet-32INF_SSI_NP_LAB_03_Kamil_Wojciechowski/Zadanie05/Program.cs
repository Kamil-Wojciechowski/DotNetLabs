namespace Zadanie05
{
    internal class Program
    {
        static int[] array = new int[] { 3, 5, 1, 7, 9, 2, 6, 8, 4 };

        static int resultMax;
        static int resultMin;

        static void Main(string[] args)
        {
            Thread threadMax = new Thread(new ThreadStart(FindMax));
            threadMax.Start();

            Thread threadMin = new Thread(new ThreadStart(FindMin));
            threadMin.Start();

            threadMax.Join();
            threadMin.Join();

            Console.WriteLine("Największa wartość: " + resultMax);
            Console.WriteLine("Najmniejsza wartość: " + resultMin);
        }

        static void FindMax()
        {
            resultMax = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > resultMax)
                {
                    resultMax = array[i];
                }
            }
        }

        static void FindMin()
        {
            resultMin = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < resultMin)
                {
                    resultMin = array[i];
                }
            }
        }
    }
}