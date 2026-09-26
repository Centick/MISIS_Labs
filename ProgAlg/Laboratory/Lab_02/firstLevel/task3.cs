
namespace ConsoleApp1
{
    internal class Task3
    {
        public static void Run()
        {
            string[] values = Console.ReadLine().Split(' ');
            double a = double.Parse(values[0]);
            double b = double.Parse(values[1]);

            double c;

            if (a > 0)
            {
                c = Math.Max(a, b);
            }
            else
            {
                c = Math.Min(a, b);
            }

            Console.WriteLine(c);
        }
    }
}