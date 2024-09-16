namespace DesignPattern.Builder;

/*The Concrete Builder classes follow the Builder interface and provide
 specific implementations of the building steps. Your program may have
 several variations of Builders, implemented differently.*/
public class ConcreteBuilder: IBuilder
{
    private Product _product = new Product();

    public ConcreteBuilder()
    {
        this.Reset();
    }

    public void Reset()
    {
        this._product = new Product();
    }

    // All production steps work with the same product instance.
    public void BuildPartA()
    {
        this._product.Add("PartA");
    }

    public void BuildPartB()
    {
        this._product.Add("PartB");
    }

    public void BuildPartC()
    {
        this._product.Add("PartC");
    }

    public Product GetProduct()
    {
        Product result = this._product;
        this.Reset();
        return result;
    }
}