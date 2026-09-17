using System;

class Program
{
    static void Main()
    {
        double a = 0.1;
        double b = 1;
        double h = 0.1;

        for (double x = a; x <= b + 0.0001; x += h)
        {
            double S = 0;
            double factorial = 1;

            for (int i = 0; i <= 10; i++)
            {
                if (i > 0)
                    factorial *= i;

                S += (2 * i + 1) * Math.Pow(x, 2 * i) / factorial;
            }

            double y = (1 + 2 * x * x) * Math.Exp(x * x);

            Console.WriteLine($"{x:F1}, {S:F6}, {y:F6}");
        }
    }
}