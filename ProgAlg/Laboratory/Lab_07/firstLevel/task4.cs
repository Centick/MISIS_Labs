namespace Lab_07_firstLevel;

internal static class Task4
{
    public static void Run()
    {
        Console.WriteLine("Уровень 1, задание № 4");
        HighJump[] athletes =
        [
            new("Климов", 1.79m, 1.85m),
            new("Волков", 1.92m, 1.86m),
            new("Громов", 1.89m, 1.83m)
        ];

        var ranked = athletes.OrderByDescending(athlete => athlete.Best());
        Console.WriteLine($"{"Место",5} {"Фамилия",-12} {"1-я, м",8} {"2-я, м",8} {"Лучший, м",10}");
        int place = 1;
        foreach (HighJump athlete in ranked)
        {
            Console.WriteLine($"{place++,5} {athlete.Name,-12} {athlete.First,8:F2} {athlete.Second,8:F2} {athlete.Best(),10:F2}");
        }
    }
}

internal sealed class HighJump : NamedRecord
{
    public readonly decimal First;
    public readonly decimal Second;

    public HighJump(string name, decimal first, decimal second) : base(name)
    {
        First = first;
        Second = second;
    }

    public decimal Best() => Math.Max(First, Second);
}
