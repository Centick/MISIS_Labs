namespace Lab_06_firstLevel;

internal static class Lab_06_run
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        if (args.Length == 0)
        {
            Task1.Run();
            Console.WriteLine();
Task4.Run();
            Console.WriteLine();
Task5.Run();
            return;
        }

        Action? run = args[0] switch
        {
            "1" => Task1.Run,
            "4" => Task4.Run,
            "5" => Task5.Run,
            _ => null
        };

        if (args.Length != 1 || run is null)
        {
            Console.Error.WriteLine("Допустимые номера заданий: 1, 4, 5.");
            Environment.ExitCode = 1;
            return;
        }

        run();
    }
}
