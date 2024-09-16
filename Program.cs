// See https://aka.ms/new-console-template for more information

using DesignPattern.Builder;

namespace DesignPattern;

class Program{
    public static void Main()
    {
        //new ClientAbstractFactory().Main(); //AbstractFactoryExample
        new ClientBuild().Main(); //AbstractFactoryExample
    }
}