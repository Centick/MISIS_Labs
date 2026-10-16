using System.Runtime.InteropServices;

namespace Lab_03_secondLevel
{
    static class Task4
    {
        public static void Run()
        {
            double[] array = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            int index_max = 0;
            double max_znach = Math.Pow(10, 9);
            double sred = array.Sum() / array.Length;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < max_znach)
                {
                    max_znach = array[i];
                    index_max = i;
                }
            }

            for (int i = index_max; i < array.Length; i++)
            {
                array[i] = sred;
            }

            Console.WriteLine(string.Join(' ', array));
        }
    }
}