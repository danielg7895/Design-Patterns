using System;
using AbstractFactoryPattern;
using BuilderPattern;
using FactoryMethodPattern;

namespace Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //RunFactoryMethod();
            //RunAbstractFactory();
            //RunBuilder();

            Console.Read();
        }

        static void RunFactoryMethod()
        {
            Console.WriteLine("##################################");
            Console.WriteLine("FACTORY METHOD");
            new FactoryMethod().Main();
            Console.WriteLine("##################################\n\n");
        }

        static void RunAbstractFactory()
        {
            Console.WriteLine("##################################");
            Console.WriteLine("ABSTRACT FACTORY");
            new AbstractFactory().Main();
            Console.WriteLine("##################################\n\n");
        }

         static void RunBuilder()
        {
            Console.WriteLine("##################################");
            Console.WriteLine("BUILDER:");
            new Builder().Main();
            Console.WriteLine("##################################\n\n");
        }
    }
}
