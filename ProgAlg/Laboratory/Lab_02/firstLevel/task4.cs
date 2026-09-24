namespace ConsoleApp1
{
    internal class Task4
    {
        public static void Run()
        {
            string[] values = Console.ReadLine().Split(' ').ToArray();
            double a = double.Parse(values[0]);
            double b = double.Parse(values[1]);
            double c = double.Parse(values[2]);

            double z = Math.Max(Math.Min(a, b), c);

            Console.WriteLine(z);
        }
    }
}