namespace DesignPattern;

public interface IAbstractProductB
{
    string UsefulFunctionB();
    //El Producto B puede hacer lo suyo... pero también puede colaborar con el ProductoA.
    //Abstract Factory se asegura de que todos los productos que crea sean de la misma variante y, por lo tanto, compatibles.
    string AnotherUsefulFunctionB(IAbstractProductA collaborator);
}