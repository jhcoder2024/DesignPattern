namespace DesignPattern.Builder;

public class ClientBuild
{
    public void Main()
    {
        var director = new Director();
        var builder = new ConcreteBuilder();
        director.Builder = builder;
        
        Console.WriteLine("Producto Basico Estandar:");
        director.BuildMinimalViableProduct();
        Console.WriteLine(builder.GetProduct().ListParts());
        
        Console.WriteLine("Producto Completo:");
        director.BuildFullFeatureProduct();
        Console.WriteLine(builder.GetProduct().ListParts());
        
        Console.WriteLine("Producto Personalizado:");
        builder.BuildPartA();
        builder.BuildPartC();
        Console.WriteLine(builder.GetProduct().ListParts());
        
    }
}