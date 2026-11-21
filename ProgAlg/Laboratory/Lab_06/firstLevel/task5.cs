namespace Lab_06_firstLevel;

internal static class Task5
{
    private struct Attestation
    {
        public readonly string Name;
        public readonly int Grade;
        public readonly int Absences;

        public Attestation(string name, int grade, int absences)
        {
            Name = name;
            Grade = grade;
            Absences = absences;
        }
    }

    public static void Run()
    {
        Console.WriteLine("Уровень 1, задание № 5");
        Attestation[] students =
        [
            new("Соколов", 2, 4),
            new("Морозов", 0, 8),
            new("Козлов", 2, 7),
            new("Лебедев", 4, 1),
            new("Орлов", 2, 2)
        ];

        var failed = students.Where(student => student.Grade == 2)
                             .OrderByDescending(student => student.Absences);
        Console.WriteLine($"{"Фамилия",-12} {"Оценка",7} {"Пропуски",9}");
        foreach (Attestation student in failed)
        {
            Console.WriteLine($"{student.Name,-12} {student.Grade,7} {student.Absences,9}");
        }
    }
}
