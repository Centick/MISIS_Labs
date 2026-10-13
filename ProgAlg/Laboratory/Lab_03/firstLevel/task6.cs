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
            Console.WriteLine($"{Math.Sqrt(n):F4}");
        }
   }
}