namespace ConsoleApp1
{
    internal class Task5
    {
        public static void Run()
        {
            string[] values = Console.ReadLine().Split(' ');
            double r = double.Parse(values[0]);
            double s = double.Parse(values[1]); 

            double a = Math.Sqrt(2 * s);
            double d = 2 * Math.Sqrt(r / Math.PI);

            if (a <= d)
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