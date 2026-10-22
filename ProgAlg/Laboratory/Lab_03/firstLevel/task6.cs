namespace Lab_03.firstLevel
{
    static class Task6
    {
        public static void Run()
        {
            string[] array = Console.ReadLine().Split(' ');
            double n = 0;
            for (int i = 0; i < array.Length; i++)
            {
                n += Math.Pow(double.Parse(array[i]), 2);
            }
            double res = Math.Sqrt(n);
            Console.WriteLine($"{res:F4}");
        }
   }
}
