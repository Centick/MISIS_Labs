namespace Lab_07_firstLevel;

internal static class Task1
{
    private sealed class LongJump : NamedRecord
    {
        public readonly string Club;
        public readonly decimal First;
        public readonly decimal Second;

        public LongJump(string name, string club, decimal first, decimal second) : base(name)
        {
            Club = club;
            First = first;
            Second = second;
        }

        public decimal Total() => First + Second;
    }

    public static void Run()
    {
        Console.WriteLine("Уровень 1, задание № 1");
        LongJump[] athletes =
        [
            new("Иванов", "Динамо", 6.21m, 6.35m),
            new("Смирнов", "Спартак", 6.08m, 6.52m),
            new("Орлов", "Локомотив", 5.94m, 6.12m)
        ];

        var ranked = athletes.OrderByDescending(athlete => athlete.Total());
        Console.WriteLine($"{"Место",5} {"Фамилия",-12} {"Общество",-12} {"1-я, м",8} {"2-я, м",8} {"Сумма, м",9}");
        int place = 1;
        foreach (LongJump athlete in ranked)
        {
            Console.WriteLine($"{place++,5} {athlete.Name,-12} {athlete.Club,-12} {athlete.First,8:F2} {athlete.Second,8:F2} {athlete.Total(),9:F2}");
        }
    }
}
