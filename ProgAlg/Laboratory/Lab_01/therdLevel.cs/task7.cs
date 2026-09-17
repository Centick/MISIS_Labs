using System;

class Program
{
    static void Main()
    {
        double a = 0.1;
        double b = 1;
        double h = 0.05;

        for (double x = a; x <= b + 0.0001; x += h)
        {
            double S = 0;
            double factorial = 1;

            for (int i = 0; i <= 10; i++)
            {
                if (i > 0)
                {
                    factorial *= (2 * i - 1) * (2 * i);
                }

                S += Math.Pow(x, 2 * i) / factorial;
            }

            double y = (Math.Exp(x) + Math.Exp(-x)) / 2;

            Console.WriteLine($"{x:F2}, {S:F6}, {y:F6}");
        }
    }
}