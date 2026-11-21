namespace Lab_07_secondLevel;

internal static class Task3
{
    private sealed class ThreeAttempts : NamedRecord
    {
        public readonly decimal[] Attempts;

        public ThreeAttempts(string name, decimal[] attempts) : base(name)
        {
            Attempts = attempts;
        }

        public decimal Best() => Attempts.Max();
    }

    public static void Run()
    {
        Console.WriteLine("Уровень 2, задание № 3");
        ThreeAttempts[] athletes =
        [
            new("Зайцев", [6.08m, 6.26m, 6.15m]),
            new("Романов", [6.11m, 6.13m, 6.40m]),
            new("Семёнов", [6.55m, 6.34m, 6.39m])
        ];

        var ranked = athletes.OrderByDescending(athlete => athlete.Best());
        Console.WriteLine($"{"Место",5} {"Фамилия",-12} {"1-я, м",8} {"2-я, м",8} {"3-я, м",8} {"Лучший, м",10}");
        int place = 1;
        foreach (ThreeAttempts athlete in ranked)
        {
            Console.WriteLine($"{place++,5} {athlete.Name,-12} {athlete.Attempts[0],8:F2} {athlete.Attempts[1],8:F2} {athlete.Attempts[2],8:F2} {athlete.Best(),10:F2}");
        }
    }
}
