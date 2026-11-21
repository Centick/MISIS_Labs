namespace Lab_06_secondLevel;

internal static class Task1
{
    private struct SessionStudent
    {
        public readonly string Name;
        public readonly int[] Grades;

        public SessionStudent(string name, int[] grades)
        {
            Name = name;
            Grades = grades;
        }

        public double Average() => Grades.Average();
    }

    public static void Run()
    {
        Console.WriteLine("Уровень 2, задание № 1");
        SessionStudent[] students =
        [
            new("Иванов", [5, 5, 4, 4]),
            new("Петров", [4, 4, 4, 4]),
            new("Сидоров", [3, 4, 4, 4]),
            new("Орлов", [5, 5, 5, 4])
        ];

        var ranked = students.Where(student => student.Average() >= 4)
                             .OrderByDescending(student => student.Average());
        Console.WriteLine($"{"Фамилия",-12} {"Оценки",-12} {"Средний балл",12}");
        foreach (SessionStudent student in ranked)
        {
            Console.WriteLine($"{student.Name,-12} {string.Join(" ", student.Grades),-12} {student.Average(),12:F2}");
        }
    }
}
