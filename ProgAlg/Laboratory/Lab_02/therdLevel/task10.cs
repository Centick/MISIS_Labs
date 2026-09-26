namespace ConsoleApp1
{
    internal class Task3
    {
        public static void Run()
        {
            Console.WriteLine("Для завершения ввода нажмите Enter");
            int coutGoodStudents = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    break;
                }

                string[] grades = input.Split(' ');

                int g1 = int.Parse(grades[0]);
                int g2 = int.Parse(grades[1]);
                int g3 = int.Parse(grades[2]);
                int g4 = int.Parse(grades[3]);

                if (g1 > 3 && g2 > 3 && g3 > 3 && g4 > 3)
                {
                    coutGoodStudents++;
                }
            }

            Console.WriteLine(coutGoodStudents);
        }
    }
}