namespace Lab_07_therdLevel;

internal static class Task5
{
    public static void Run()
    {
        Console.WriteLine("Уровень 3, задание № 5");
        Match[] matches =
        [
            new("Факел", "Старт", 2, 0),
            new("Факел", "Луч", 0, 1),
            new("Луч", "Вектор", 3, 0),
            new("Старт", "Вектор", 1, 1),
            new("Луч", "Старт", 0, 2),
            new("Факел", "Вектор", 1, 1)
        ];

        var standings = new Dictionary<string, TeamStanding>();
        foreach (Match match in matches)
        {
            Update(standings, match.Home, match.HomeGoals, match.AwayGoals);
            Update(standings, match.Away, match.AwayGoals, match.HomeGoals);
        }

        var ranked = standings.Values.OrderByDescending(team => team.Points)
                              .ThenByDescending(team => team.GoalDifference)
                              .ThenBy(team => team.Name, StringComparer.Ordinal);
        Console.WriteLine($"{"Место",5} {"Команда",-12} {"Очки",5}");
        int place = 1;
        foreach (TeamStanding team in ranked)
        {
            Console.WriteLine($"{place++,5} {team.Name,-12} {team.Points,5}");
        }
    }

    private static void Update(Dictionary<string, TeamStanding> standings, string name, int scored, int conceded)
    {
        if (!standings.TryGetValue(name, out TeamStanding? team))
        {
            team = new TeamStanding(name);
            standings.Add(name, team);
        }

        team.AddResult(scored, conceded);
    }
}

internal sealed class TeamStanding : NamedRecord
{
    public TeamStanding(string name) : base(name)
    {
    }

    public int Points { get; private set; }
    public int GoalDifference { get; private set; }

    public void AddResult(int scored, int conceded)
    {
        GoalDifference += scored - conceded;
        if (scored > conceded)
        {
            Points += 3;
        }
        else if (scored == conceded)
        {
            Points++;
        }
    }
}

internal sealed class Match
{
    public readonly string Home;
    public readonly string Away;
    public readonly int HomeGoals;
    public readonly int AwayGoals;

    public Match(string home, string away, int homeGoals, int awayGoals)
    {
        Home = home;
        Away = away;
        HomeGoals = homeGoals;
        AwayGoals = awayGoals;
    }
}
