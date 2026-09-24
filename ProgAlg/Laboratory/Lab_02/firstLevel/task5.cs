namespace ConsoleApp1
{
    internal class Task3
    {
        public static void Run()
        {
            string[] values = Console.ReadLine().Split(' ').ToArray();
            double r = double.Parse(values[0]);
            double s = double.Parse(values[1]);

            double a = Math.Sqrt(s);
            double d = 2 * Math.Sqrt(r / Math.PI);
            if (d <= a)
            {
                Console.WriteLine("помещается");
            }
            else
            {
                Console.WriteLine("не помещается");
            }
        }
    }
}