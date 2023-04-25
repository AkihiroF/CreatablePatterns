namespace CreatablePatterns.AbstractFactoryPattern;

public class ClientBuilder
{
    private AbstractProductA _productA;
    private AbstractProductB _productB;

    public ClientBuilder(AbstractFactory factory)
    {
        _productA = factory.CreateProductA();
        _productB = factory.CreateProductB();
    }

    public void Run()
    {
        
    }
}