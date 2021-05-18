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
using IteratorPattern;
using StatePattern;
using ObserverPattern;
using TemplateMethodPattern;
using ChainOfResponsibilityPattern;
using CommandPattern;
using MediatorPattern;
using StrategyPattern;

namespace Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            
            while(true)
            {

                try
                {
                    Console.WriteLine("1. RunFactoryMethod");
                    Console.WriteLine("2. RunAbstractFactory");
                    Console.WriteLine("3. RunBuilder");
                    Console.WriteLine("4. RunPrototype");
                    Console.WriteLine("5. RunSingleton");
                    Console.WriteLine("6. RunAdapter");
                    Console.WriteLine("7. RunComposite");
                    Console.WriteLine("8. RunDecorator");
                    Console.WriteLine("9. RunFacade");
                    Console.WriteLine("10. RunProxy");
                    Console.WriteLine("11. RunIterator");
                    Console.WriteLine("12. RunObserver");
                    Console.WriteLine("13. RunTemplateMethod");
                    Console.WriteLine("14. RunState");
                    Console.WriteLine("15. RunStrategy");
                    Console.WriteLine("16. RunChainOfResponsibility");
                    Console.WriteLine("17. RunCommand");
                    Console.WriteLine("18. RunMediator");
                    Console.WriteLine("0. Exit");
                    Console.WriteLine("");
                    Console.Write("Choose an option: ");
                    int option = int.Parse(Console.ReadLine());
                    Console.WriteLine("");

                    switch (option)
                    {
                        case 1: RunFactoryMethod(); break;
                        case 2: RunAbstractFactory(); break;
                        case 3: RunBuilder(); break;
                        case 4: RunPrototype(); break;
                        case 5: RunSingleton(); break;
                        case 6: RunAdapter(); break;
                        case 7: RunComposite(); break;
                        case 8: RunDecorator(); break;
                        case 9: RunFacade(); break;
                        case 10: RunProxy(); break;
                        case 11: RunIterator(); break;
                        case 12: RunObserver(); break;
                        case 13: RunTemplateMethod(); break;
                        case 14: RunState(); break;
                        case 15: RunStrategy(); break;
                        case 16: RunChainOfResponsibility(); break;
                        case 17: RunCommand(); break;
                        case 18: RunMediator(); break;
                        case 0: Environment.Exit(1); break;
                        default: continue;
                    }
                } catch
                {
                    Console.WriteLine("Invalid option");
                    continue;
                }

            }

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
        static void RunState()
        {
            Console.WriteLine("##################################");
            Console.WriteLine("STATE:");
            new State().Main();
            Console.WriteLine("##################################\n\n");
        }

        static void RunStrategy()
        {
            Console.WriteLine("##################################");
            Console.WriteLine("STRATEGY:");
            new Strategy().Main();
            Console.WriteLine("##################################\n\n");
        }

        static void RunChainOfResponsibility()
        {
            Console.WriteLine("##################################");
            Console.WriteLine("CHAIN OF RESPONSIBILITY:");
            new ChainOfResponsibility().Main();
            Console.WriteLine("##################################\n\n");
        }

        static void RunCommand()
        {
            Console.WriteLine("##################################");
            Console.WriteLine("COMMAND:");
            new Command().Main();
            Console.WriteLine("##################################\n\n");
        }

        static void RunMediator()
        {
            Console.WriteLine("##################################");
            Console.WriteLine("MEDIATOR:");
            new Mediator().Main();
            Console.WriteLine("##################################\n\n");
        }
    }
}
