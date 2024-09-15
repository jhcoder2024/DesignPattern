namespace DesignPattern;

public class ClientAbstractFactory
{
    public void Main()
    {
        Console.WriteLine("Client: Testing client code with the first factory type...");
        ClientMethod(new ConcreteFactoryType1());
        Console.WriteLine();

        Console.WriteLine("Client: Testing the same client code with the second factory type...");
        ClientMethod(new ConcreteFactoryType2());
    }

    public void ClientMethod(IAbstractFactory factory)
    {
        var productA = factory.CreateProductA();
        var productB = factory.CreateProductB();
        Console.WriteLine(productA.UsefulFunctionA());
        Console.WriteLine(productB.AnotherUsefulFunctionB(productA));
    }
}