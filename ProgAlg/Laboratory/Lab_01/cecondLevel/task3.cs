    namespace ConsoleApp1
    {
        internal class Task1
        {
            public static void Run()
            {
                double a = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                double p = double.Parse(Console.ReadLine());

                double s = 0;
                int n = 0;

                while (s + a + n * h <= p)
                {
                    s = s + a + n * h;
                    n++;
                }

                Console.WriteLine(n);
            }
        }
    }
