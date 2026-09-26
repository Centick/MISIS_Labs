namespace ConsoleApp1
{
    internal class Task4
    {
        public static void Run()
        {
            int n = int.Parse(Console.ReadLine());

            int a = 0;
            double b = 0;

            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                int g1 = int.Parse(values[0]); 
                int g2 = int.Parse(values[1]); 
                int g3 = int.Parse(values[2]); 
                int g4 = int.Parse(values[3]); 

                if (g1 == 2 || g2 == 2 || g3 == 2 || g4 == 2)
                {
                    a++;
                }

                b += g1 + g2 + g3 + g4; 
            }

            double g = b / (n * 4.0); 

            Console.WriteLine(a);
            Console.WriteLine(g);
        }
    }
}