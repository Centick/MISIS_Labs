namespace ConsoleApp1
{
    internal class Task1
    {
        public static void Run()
        {
            int cells = 10;

            for (int time = 3; time <= 24; time += 3)
            {
                cells *= 2;
                Console.WriteLine("Через " + time + " часов: " + cells + " клеток");
            }
        }
    }
}

