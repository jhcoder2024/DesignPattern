// See https://aka.ms/new-console-template for more information

using DesignPattern.Builder;
using DesignPattern.Prototype;

namespace DesignPattern;

class Program{
    public static void Main()
    {
        new ClientAbstractFactory().Main(); //AbstractFactoryExample
        new ClientBuild().Main(); //BuildExample
        new ClientPrototype().Main();//PrototypeExample
    }
}