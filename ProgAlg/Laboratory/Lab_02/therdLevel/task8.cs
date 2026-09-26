namespace ConsoleApp1
{
    static class Task1
    {
        public static void Run()
        {
            Console.WriteLine("Для завершения ввода нажмите Enter");

            double minDistance = double.MaxValue;
            int index = 0;
            double xCount = 0, yCount = 0;

            while (true)
            {   
                string input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                    break;

                string[] parts = input.Split(' ');
                if (parts.Length < 2)
                {
                    break;
                }
                double x = double.Parse(parts[0]);
                double y = double.Parse(parts[1]);
                index++;

                double distance = Math.Sqrt(x * x + y * y);
                if (distance < minDistance)
                {
                    minDistance = distance;
                    xCount = x;
                    yCount = y;
                }
            }

            if (index > 0)
            {
                Console.WriteLine($"({xCount}, {yCount}) - {minDistance}");
            }
            else
            {
                Console.WriteLine("Данные не были введены.");
            }
        }
    }
}
