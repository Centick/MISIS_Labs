using System.Runtime.InteropServices;

namespace Lab_03_secondLevel
{
    static class Task3
    {
        public static void Run()
        {
            double[] array = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            int index_max = 0;
            double max_znach = Math.Pow(10, 9);

            int Length = array.Length;
            for (int i = 0; i < Length; i++)
            {
                if (array[i] < max_znach)
                {
                    max_znach = array[i];
                    index_max = i;
                }
            }

            for (int i = 0; i < index_max; i++)
            {
                array[i] = array[i] * 2;
            }

            Console.WriteLine(string.Join(' ', array));
        }
    }
}