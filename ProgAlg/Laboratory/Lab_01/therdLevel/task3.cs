namespace ConsoleApp1
{
    internal class Task1
    {
        public static void Run()
        {
            double a = 0.1;
            double b = 1;
            double h = 0.1;

            for (double x = a; x <= b + 0.0001; x += h)
            {
                double S = 1;
                double f = 1;

                for (int i = 1; i <= 10; i++)
                {
                    f *= i;
                    S += Math.Cos(i * x) / f;
                }

                double y = Math.Exp(Math.Cos(x)) * Math.Cos(Math.Sin(x));

                Console.WriteLine($"{x:F1}, {S:F6}, {y:F6}");
            }
        }
    }
}

