namespace Lab_03_secondLevel
{
    static class Task1
    {
        public static void Run()
        {
            double[] array = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            int index_min = 0;
            double min_znach = Math.Pow(10, 9);

            int Length = array.Length;
            for (int i = 0; i < Length; i++)
            {
                if (array[i] < min_znach)
                {
                    min_znach = array[i];
                    index_min = i;
                }
            }

            array[index_min] = min_znach * 2;
            Console.WriteLine(string.Join(' ', array));

            
        }
    }
}