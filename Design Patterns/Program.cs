using System;
using AbstractFactoryPattern;
using AdapterPattern;
using BuilderPattern;
using CompositePattern;
using FactoryMethodPattern;
using PrototypePattern;
using SingletonPattern;

namespace Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //RunFactoryMethod();
            //RunAbstractFactory();
            //RunBuilder();
            //RunPrototype();
            //RunSingleton();
            //RunAdapter();
            RunComposite();

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

        static void RunPrototype()
        {
            Console.WriteLine("##################################");
            Console.WriteLine("PROTOTYPE:");
            new Prototype().Main();
            Console.WriteLine("##################################\n\n");
        }

        static void RunSingleton()
        {
            Console.WriteLine("##################################");
            Console.WriteLine("SINGLETON:");
            new Singleton().Main();
            Console.WriteLine("##################################\n\n");
        }

        static void RunAdapter()
        {
            Console.WriteLine("##################################");
            Console.WriteLine("ADAPTER:");
            new Adapter().Main();
            Console.WriteLine("##################################\n\n");
        }

        static void RunComposite()
        {
            Console.WriteLine("##################################");
            Console.WriteLine("COMPOSITE:");
            new Composite().Main();
            Console.WriteLine("##################################\n\n");
        }
    }
}
