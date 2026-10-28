namespace Lab_03.firstLevel
{
    static class Task8
    {
        public static void Run()
        {
            double[] array = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double a = array.Sum() / array.Length;
            int n = 0;

            int Length = array.Length;
            for (int i = 0; i < Length; i++)
                if (array[i] > 0) n ++;

            Console.WriteLine(n);
        }
    }
}