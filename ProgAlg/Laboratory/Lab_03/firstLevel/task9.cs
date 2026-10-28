namespace Lab_03.firstLevel
{
    static class Task9
    {
        public static void Run()
        {
            double[] array = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double sred = array.Sum() / array.Length;
            int n = 0;
            int Length = array.Length;
            for (int i = 0; i < Length; i++)
                if (array[i] > sred)
                    n += 1;

            Console.WriteLine(n);
        }
    }
}