namespace ConsoleApp1
{
    internal class Task1
    {
        public static void Run()
        {
            for (double x = -4; x <= 4; x += 0.5)
            {
                double y = 0.5 * x * x - 7 * x;
                Console.WriteLine("f(" + x + "): " + y);
            }
        }
    }
}
