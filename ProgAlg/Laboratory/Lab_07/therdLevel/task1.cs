namespace Lab_07_therdLevel;

internal static class Task1
{
    private sealed class StudyGroup : NamedRecord
    {
        public readonly int[][] Grades;

        public StudyGroup(string name, int[][] grades) : base(name)
        {
            Grades = grades;
        }

        public double Average() => Grades.SelectMany(student => student).Average();
    }

    public static void Run()
    {
        Console.WriteLine("Уровень 3, задание № 1");
        StudyGroup[] groups =
        [
            new("БИВТ-1", [[5, 4, 5, 4, 5], [4, 3, 4, 4, 4]]),
            new("БИВТ-2", [[5, 5, 4, 5, 5], [5, 4, 4, 5, 5], [4, 5, 5, 5, 5]]),
            new("БИВТ-3", [[3, 5, 4, 4, 5], [4, 4, 4, 4, 4]])
        ];

        var ranked = groups.OrderByDescending(group => group.Average());
        Console.WriteLine($"{"Группа",-12} {"Студентов",10} {"Средний балл",12}");
        foreach (StudyGroup group in ranked)
        {
            Console.WriteLine($"{group.Name,-12} {group.Grades.Length,10} {group.Average(),12:F2}");
        }
    }
}
