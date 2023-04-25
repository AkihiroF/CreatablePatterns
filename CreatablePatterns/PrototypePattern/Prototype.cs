namespace CreatablePatterns;

public abstract class Prototype
{
    public readonly int Id;

    public Prototype(int id)
    {
        Id = id;
    }

    public abstract Prototype Clone();

}