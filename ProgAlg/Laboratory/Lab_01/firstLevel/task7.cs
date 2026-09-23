namespace ConsoleApp1
{
    internal class Task1
    {
        public static void Run()
        {
            int f = 1;

            for (int i = 1; i <= 6; i++)
            {
                f = f * i;
            }

            Console.WriteLine(f);
        }
    }
}
