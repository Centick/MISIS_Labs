namespace Lab_07_therdLevel;

internal abstract class NamedRecord
{
    public string Name { get; }

    protected NamedRecord(string name)
    {
        Name = name;
    }
}
