using System.Runtime.InteropServices;

namespace Lab_03_secondLevel
{
    static class Task2
    {
        public static void Run()
        {
            double[] array = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            int index_max = 0;
            double max_znach = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max_znach)
                {
                    max_znach = array[i];
                    index_max = i;
                }
            }

            double sumArray = 0;
            for (int i = 0; i < index_max; i++)
            {
                sumArray += array[i];
            }

            Console.WriteLine(sumArray);
        }
    }
}