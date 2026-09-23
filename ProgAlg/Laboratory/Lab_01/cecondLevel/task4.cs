namespace ConsoleApp1
{
    internal class Task1
    {
        public static void Run()
        {
            double x = double.Parse(Console.ReadLine());

            double s = 0;
            double a = 1;

            while (a >= 0.0001)
            {
                s = s + a;
                a = a * x * x;
            }

            Console.WriteLine(s);
        }
    }
}
