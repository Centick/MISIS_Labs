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

            for (int i = 1; i <= 1000; i++)
            {
                S += Math.Pow(-1, i + 1) * Math.Pow(x, 2 * i + 1)
                     / (4 * i * i - 1);
            }

            double y = ((1 + x * x) * Math.Atan(x)) / 2 - x / 2;

            Console.WriteLine($"{x:F1}, {S:F6}, {y:F6}");
        }
    }
}