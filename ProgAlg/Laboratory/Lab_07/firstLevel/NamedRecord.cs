namespace Lab_07_firstLevel;

internal abstract class NamedRecord
{
    public string Name { get; }

    protected NamedRecord(string name)
    {
        Name = name;
    }
}
