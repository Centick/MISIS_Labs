namespace Lab_06_therdLevel;

internal static class Task4
{
    public static void Run()
    {
        Console.WriteLine("Уровень 3, задание № 4");
        SkiGroup[] groups =
        [
            new("1", [new("Иванов", 705), new("Орлов", 681), new("Климов", 710)]),
            new("2", [new("Серов", 697), new("Белов", 673), new("Громов", 705)])
        ];

        Skier[] first = groups[0].Ranked();
        Skier[] second = groups[1].Ranked();
        Console.WriteLine($"Группа {groups[0].Name}");
        Print(first);
        Console.WriteLine($"Группа {groups[1].Name}");
        Print(second);

        Console.WriteLine("Общий протокол");
        Print(Merge(first, second));
    }

    private static Skier[] Merge(Skier[] first, Skier[] second)
    {
        Skier[] merged = new Skier[first.Length + second.Length];
        int i = 0;
        int j = 0;
        while (i < first.Length && j < second.Length)
        {
            if (first[i].Seconds <= second[j].Seconds)
            {
                merged[i + j] = first[i];
                i++;
            }
            else
            {
                merged[i + j] = second[j];
                j++;
            }
        }

        Array.Copy(first, i, merged, i + j, first.Length - i);
        Array.Copy(second, j, merged, first.Length + j, second.Length - j);
        return merged;
    }

    private static void Print(Skier[] athletes)
    {
        Console.WriteLine($"{"Место",5} {"Фамилия",-12} {"Время, м:с",10}");
        for (int i = 0; i < athletes.Length; i++)
        {
            Console.WriteLine($"{i + 1,5} {athletes[i].Name,-12} {athletes[i].Time(),10}");
        }
    }
}

internal struct SkiGroup
{
    public readonly string Name;
    public readonly Skier[] Athletes;

    public SkiGroup(string name, Skier[] athletes)
    {
        Name = name;
        Athletes = athletes;
    }

    public Skier[] Ranked() => Athletes.OrderBy(athlete => athlete.Seconds).ToArray();
}

internal struct Skier
{
    public readonly string Name;
    public readonly int Seconds;

    public Skier(string name, int seconds)
    {
        Name = name;
        Seconds = seconds;
    }

    public string Time() => $"{Seconds / 60}:{Seconds % 60:D2}";
}
