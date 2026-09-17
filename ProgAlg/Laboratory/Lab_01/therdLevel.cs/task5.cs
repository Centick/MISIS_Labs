using System;

class Program
{
    static void Main()
    {
        double a = Math.PI / 5;
        double b = Math.PI;
        double h = Math.PI / 25;

        for (double x = a; x <= b + 0.0001; x += h)
        {
            double S = 0;

            for (int i = 1; i <= 1000; i++)
            {
                S += Math.Pow(-1, i) * Math.Cos(i * x) / (i * i);
            }

            double y = (x * x - Math.PI * Math.PI / 3) / 4;

            Console.WriteLine($"{x:F4}, {S:F6}, {y:F6}");
        }
    }
}