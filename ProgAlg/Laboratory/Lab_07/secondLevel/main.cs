namespace Lab_07_secondLevel;

internal static class Lab_07_run
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        if (args.Length == 0)
        {
            Task1.Run();
            Console.WriteLine();
Task2.Run();
            Console.WriteLine();
Task3.Run();
            return;
        }

        Action? run = args[0] switch
        {
            "1" => Task1.Run,
            "2" => Task2.Run,
            "3" => Task3.Run,
            _ => null
        };

        if (args.Length != 1 || run is null)
        {
            Console.Error.WriteLine("Допустимые номера заданий: 1, 2, 3.");
            Environment.ExitCode = 1;
            return;
        }

        run();
    }
}
