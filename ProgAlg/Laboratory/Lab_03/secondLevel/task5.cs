using System.Runtime.InteropServices;

namespace Lab_03_secondLevel
{
    static class Task5
    {
        public static void Run()
        {
            double[] array = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            
            int index_max = 0;
            double max_znach = Math.Pow(10, 9);
            
            int index_min = 0;
            double min_znach = 0;
            
            double sred = array.Sum() / array.Length;
            
            int Length = array.Length;
            // найдем индекс и значение минимального числа 
            for (int i = 0; i < Length; i++)
            {
                if (array[i] < max_znach)
                {
                    max_znach = array[i];
                    index_max = i;
                }
            }

            
            // найдем индекс и значение максимального числа
            for (int i = 0; i < Length; i++)
            {
                if (array[i] > max_znach)
                {
                    max_znach = array[i];
                    index_max = i;
                }
            }

            List<double> arrayCount = new List<double>();
            for (int i = Math.Min(index_max, index_min) + 1; i < Math.Max(index_max, index_min); i++)
            {
                arrayCount.Add(-array[i]);
            }

            Console.WriteLine(string.Join(' ', arrayCount));
        }
    }
}