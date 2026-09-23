namespace ConsoleApp1
{
    internal class Task1
    {
        public static void Run()
        {
            int f = 1;
            int s = 0;

            for (int i = 1; i <= 6; i++)
            {
                f = f * i;
                s = s + f;
            }

            Console.WriteLine(s);
        }
    }
}
