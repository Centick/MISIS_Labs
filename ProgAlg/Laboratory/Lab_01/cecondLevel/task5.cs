namespace ConsoleApp1
{
    internal class Task1
    {
        static void Run()
        {
            double m = double.Parse(Console.ReadLine());
            double n = double.Parse(Console.ReadLine());
            double i = 0;

            while (m > n)
            {
                m = m - n;
                i++;
            }
            Console.Write(i);
            Console.Write(m);
        }
    }
}
