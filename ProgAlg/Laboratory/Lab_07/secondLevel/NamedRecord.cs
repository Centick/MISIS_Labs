namespace Lab_07_secondLevel;

internal abstract class NamedRecord
{
    public string Name { get; }

    protected NamedRecord(string name)
    {
        Name = name;
    }
}
