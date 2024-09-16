namespace DesignPattern.Builder;
/*
  It makes sense to use the Builder pattern only when your products are
  quite complex and require extensive configuration.
  Unlike in other creational patterns, different concrete builders can
  produce unrelated products. In other words, results of various builders
  may not always follow the same interface.
 */
public class Product
{
    private List<object> _parts = new List<object>();

    public void Add(string part)
    {
        this._parts.Add(part);
    }

    public string ListParts()
    {
        string str = String.Empty;
        foreach (var part in _parts)
        {
            str += part + ", ";
        }

        str = str.Remove(str.Length - 2); //removing last ",c"
        return "Product parts: " + str + "\n";
    }
}