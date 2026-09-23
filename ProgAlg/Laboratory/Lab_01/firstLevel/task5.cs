namespace ConsoleApp1
{
    internal class Task1
    {
        public static void Run()
        {
            double p = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double s = 0;

            for (int i = 0; i < 10; i++)
            {
                s += Math.Pow(p + i * h, 2);
            }

            Console.WriteLine(s);
        }
    }
}

