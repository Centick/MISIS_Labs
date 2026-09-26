namespace ConsoleApp1
{
    internal class Task2
    {
        public static void Run()
        {
            string[] values = Console.ReadLine().Split(' ');
            double x = double.Parse(values[0]);
            double y = double.Parse(values[1]);


            if (y >= 0 && y + Math.Abs(x) <= 1)
            {
                Console.WriteLine("Да");
            }
            else
            {
                Console.WriteLine("Нет");
            }
        }
    }
}