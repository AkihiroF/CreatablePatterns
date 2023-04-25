namespace CreatablePatterns.BuilderPattern;

public class ConcreteBuilder : Builder
{
    private ProductBuilder product;

    public ConcreteBuilder()
    {
        product = new();
    }
    
    public override void BuildPartA()
    {
        product.Add("a");
    }

    public override void BuildPartB()
    {
        product.Add("b");
    }

    public override void BuildPartC()
    {
        product.Add("c");
    }

    public override ProductBuilder GetResult()
    {
        return product;
    }
}