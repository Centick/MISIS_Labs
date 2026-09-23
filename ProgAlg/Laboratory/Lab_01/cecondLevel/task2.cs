namespace ConsoleApp1
{
    internal class Task1
    {
        public static void Run()
        {
            int p = 1;
            int n = 1;

            while (p * (n + 3) <= 30000) {
                n = n + 3;
                p = p * n;
            }

            Console.WriteLine(n);
            Console.WriteLine(p);
        }
    }
}
