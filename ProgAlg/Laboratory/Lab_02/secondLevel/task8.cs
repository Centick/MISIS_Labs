namespace ConsoleApp1
{
    static class Task1
    {
        public static void Run()
        {
            int n = int.Parse(Console.ReadLine());

            double minPoint = 10_000_000;
            double xCout = 0, yCout = 0;
            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                double x = double.Parse(values[0]);
                double y = double.Parse(values[1]);

                double qwe = Math.Sqrt(x * x + y * y);
                if (minPoint > qwe)
                {
                    minPoint = qwe;
                    xCout = x;
                    yCout = y;
                }
            }
            Console.WriteLine($"({xCout}, {yCout}) - {minPoint}");
        }
    }
}
