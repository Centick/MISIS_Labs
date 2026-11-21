namespace Lab_06_secondLevel;

internal static class Task2
{
    public static void Run()
    {
        Console.WriteLine("Уровень 2, задание № 2");
        Applicant[] students =
        [
            new("Белов", [5, 4, 5]),
            new("Егоров", [5, 2, 5]),
            new("Котов", [4, 3, 4]),
            new("Серов", [5, 5, 5])
        ];

        var ranked = students.Where(student => student.Passed())
                             .OrderByDescending(student => student.Average());
        Console.WriteLine($"{"Фамилия",-12} {"Мат.",5} {"Физ.",5} {"Рус.",5} {"Средний балл",12}");
        foreach (Applicant student in ranked)
        {
            Console.WriteLine($"{student.Name,-12} {student.Grades[0],5} {student.Grades[1],5} {student.Grades[2],5} {student.Average(),12:F2}");
        }
    }
}

internal struct Applicant
{
    public readonly string Name;
    public readonly int[] Grades;

    public Applicant(string name, int[] grades)
    {
        Name = name;
        Grades = grades;
    }

    public bool Passed() => !Grades.Contains(2);
    public double Average() => Grades.Average();
}
