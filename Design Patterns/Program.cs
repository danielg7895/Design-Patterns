using System;
using AbstractFactoryPattern;
using AdapterPattern;
using BuilderPattern;
using CompositePattern;
using FactoryMethodPattern;
using PrototypePattern;
using SingletonPattern;
using DecoratorPattern;
using FacadePattern;
using ProxyPattern;
using ChainOfResponsabilityPattern;
using CommandPattern;
using IteratorPattern;
using MediatorPattern;
using ObserverPattern;
using StatePattern;
using StrategyPattern;
using TemplateMethodPattern;

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
            //RunComposite();
            //RunDecorator();
            //RunFacade();
            //RunProxy();
            //RunIterator();
            //RunObserver();
            RunTemplateMethod();

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

        static void RunDecorator()
        {
            Console.WriteLine("##################################");
            Console.WriteLine("DECORATOR:");
            new Decorator().Main();
            Console.WriteLine("##################################\n\n");
        }

        static void RunFacade()
        {
            Console.WriteLine("##################################");
            Console.WriteLine("FACADE:");
            new Facade().Main();
            Console.WriteLine("##################################\n\n");
        }

        static void RunProxy()
        {
            Console.WriteLine("##################################");
            Console.WriteLine("PROXY:");
            new Proxy().Main();
            Console.WriteLine("##################################\n\n");
        }

        static void RunIterator()
        {
            Console.WriteLine("##################################");
            Console.WriteLine("ITERATOR:");
            new Iterator().Main();
            Console.WriteLine("##################################\n\n");
        }

        static void RunObserver()
        {
            Console.WriteLine("##################################");
            Console.WriteLine("OBSERVER:");
            new Observer().Main();
            Console.WriteLine("##################################\n\n");
        }

        static void RunTemplateMethod()
        {
            Console.WriteLine("##################################");
            Console.WriteLine("TEMPLATE METHOD:");
            new TemplateMethod().Main();
            Console.WriteLine("##################################\n\n");
        }
    }
}
