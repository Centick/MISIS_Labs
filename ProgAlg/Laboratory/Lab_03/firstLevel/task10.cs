namespace Lab_03.firstLevel
{
    static class Task10
    {
        public static void Run()
        {
            double[] array = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double  = double.Parse(Console.ReadLine());
            double q = double.Parse(Console.ReadLine());
            int n = 0;

            for (int i = 0; i < array.Length; i++)
                if (array[i] > p && array[i] < q)
                    n += 1;

            Console.WriteLine(n);
        }
    }
}