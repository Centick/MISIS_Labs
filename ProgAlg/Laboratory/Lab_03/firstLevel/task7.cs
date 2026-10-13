namespace Lab_03.firstLevel
{
    static class Task7
    {
        public static void Run()
        {
            double[] array = Console.ReadLine().Split(' ').Select(double.Parse);
            double sred = Math.Sum(array) / array.Length;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > sred)
                {
                    array[i] = 0;
                }
            }
            Console.WriteLine(string.Join(" ", array));
        }
    }
}