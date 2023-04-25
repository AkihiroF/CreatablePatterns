namespace CreatablePatterns.PrototypePattern;

public class ConcretePrototype1 : Prototype
{
    public ConcretePrototype1(int id) : base(id)
    {
    }

    public override Prototype Clone()
    {
        return (Prototype)this.MemberwiseClone();
    }
}