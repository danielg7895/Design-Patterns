using System;
using AbstractFactoryPattern;
using BuilderPattern;
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
            RunSingleton();

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
    }
}
