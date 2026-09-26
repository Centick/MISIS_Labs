namespace ConsoleApp1
{
    public static class Task1
    {
        public static void Run()
        {
            int r = 2;
            string[] values = Console.ReadLine().Split(' ');
            double x = double.Parse(values[0]);
            double y = double.Parse(values[1]);
            if (Math.Abs(x * x + y * y - r * r) <= Math.Pow(10, -3))
            {
                Console.WriteLine("Да");
            }
            else
            {
                Console.WriteLine("Нет");
            }
        }
    }
}
