namespace CreatablePatterns.BuilderPattern;

public abstract class Builder
{
    public Builder()
    {
        
    }

    public abstract void BuildPartA();
    public abstract void BuildPartB();
    public abstract void BuildPartC();
    
    public abstract ProductBuilder GetResult();
}