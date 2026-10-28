namespace Lab_03_therdLevel
{
    static class Task8
    {
        public static void Run()
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int temp;
            int Length = array.Length;
            for (int i = 0; i < array.Length - 1; i++) 
            {
                if (array[i] >= 0) continue;
                for (int j = i + 1; j < Length; j++)
                {
                    if (array[j] < 0)
                    {
                        if (array[j] > array[i])
                        {
                            temp = array[i];
                            array[i] = array[j];
                            array[j] = temp;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", array));
        }
    }
}

