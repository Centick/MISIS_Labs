namespace Lab_03_therdLevel
{
    static class Task7
    {
        public static void Run()
        {
            double[] array = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            List<double> arrayCountMinus = new List<double>();
            List<double> arrayCountPlus = new List<double>();

            int Length = array.Length;
            for (int i = 0; i < Length; i++)
            {
                if (array[i] < 0) arrayCountMinus.Add(array[i]);
                else arrayCountPlus.Add(array[i]);
            }

            Console.WriteLine($"{string.Join(' ', arrayCountPlus)} {string.Join(' ', arrayCountMinus)}");
        }
    }
}