namespace CreatablePatterns.BuilderPattern;

public class ProductBuilder
{
    private List<object> _parts;

    public ProductBuilder()
    {
        _parts = new List<object>();
    }

    public void Add(string part) => _parts.Add(part);
}