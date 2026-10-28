namespace Lab_03_therdLevel
{
    static class Task9
    {
        public static void Run()
        {
            double[] array = Console.ReadLine().Split(' ').Select(double.Parse);
            int maxx = 0;
            int count = 0;
            int Length = array.Length;
            for (int i = 0; i < Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] > array[j - 1]) count++;
                    else { 
                        if (count > maxx) maxx = count;
                        count = 0;
                        break;
                    }
                }
                if (count > maxx) maxx = count;
            }
            Console.WriteLine(maxx + 1);
        }
    }
}