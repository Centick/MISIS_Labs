namespace ConsoleApp1
{
    internal class Task1
    {
        public static void Run()
        {
            double x = double.Parse(Console.ReadLine());
            double s = 0;

            for (int i = 1; i <= 9; i++) {
                s += Math.Cos(i * x) / Math.Pow(x, i - 1);
            }

            Console.WriteLine(s);
        }
    }
}
