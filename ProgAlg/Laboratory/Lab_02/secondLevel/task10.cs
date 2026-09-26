namespace ConsoleApp1
{
    internal class Task3
    {
        public static void Run()
        {
            int n = int.Parse(Console.ReadLine());
            int coutGoodStudents = 0;
            for (int i = 0; i < n; i++)
            {
                string[] grades = Console.ReadLine().Split(' ');

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