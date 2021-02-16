using System;

namespace AbstractFactoryPattern
{
    class AbstractFactory
    {
        public void Main()
        {

            new Client().Main();
        }
    }

    class Client
    {
        public void Main()
        {
            // creating dogs, dragons and creatures, showing their name and race
            IAbstractFactory dogsFactory = new CanineFactory();
            CreateFactory(dogsFactory);
            Console.WriteLine("");

            IAbstractFactory dragonsFactory = new DragonFactory();
            CreateFactory(dragonsFactory);
            Console.WriteLine("");

            IAbstractFactory creaturesFactory = new CreatureFactory();
            CreateFactory(creaturesFactory);
        }

        public void CreateFactory(IAbstractFactory factory)
        {
            factory.CreateRace().ShowRaceName();
            factory.CreateEnemy().ShowName();
        }
    }


    #region AbstractProductA & ConcreteProductA
    // AbstractProductA
    interface IRace
    {
        public abstract void ShowRaceName();
    }

    // ConcretProductA1
    class Dragon : IRace
    {
        public void ShowRaceName()
        {
            Console.WriteLine("I'm a Dragon!");
        }

    }

    // ConcretProductA2
    class Creature : IRace
    {
        public void ShowRaceName()
        {
            Console.WriteLine("I'm a Creature!");
        }
    }

    // ConcreteProductA3
    class Canine : IRace
    {
        public void ShowRaceName()
        {
            Console.WriteLine("I'm a Canine!");
        }
    }

    #endregion

    #region AbstractProductB y ConcreteProductB
    // AbstractProductB
    interface IEnemy
    {
        public abstract void ShowName();
    }

    // ConcreteProductB1
    class Gremlin : IEnemy
    {
        public void ShowName()
        {
            Console.WriteLine("I'm a Gremlin, i'm going to kill you with my big stick!");
        }
    }

    // ConcreteProductB2
    class Gargoyle : IEnemy
    {
        public void ShowName()
        {
            Console.WriteLine("I will stab my wings in your throat!");
        }
    }

    // ConcreteProductB3
    class Wolf : IEnemy
    {
        public void ShowName()
        {
            Console.WriteLine("Woof wof wof wof wooofofofo foo!.");
        }
    }
    #endregion


    #region Creacion de fabricas

    #region AbstractFactory

    interface IAbstractFactory
    {
        public abstract IRace CreateRace();     // CreateProductA
        public abstract IEnemy CreateEnemy();   // CreateProductB
    }

    // ConcreteFactory1
    class DragonFactory : IAbstractFactory
    {
        // Factory that creates dragon monsters
        // Actually there is only a dragon, so it will returns always a gargoyle (assuming gargoyle its a dragon...)
        public IRace CreateRace() { return new Dragon(); }
        public IEnemy CreateEnemy() { return new Gargoyle(); }
    }

    // ConcreteFactory2
    class CreatureFactory : IAbstractFactory
    {
        // Factory that creates enemies that i don't know what their races are
        public IEnemy CreateEnemy() { return new Gremlin();}
        public IRace CreateRace() { return new Creature(); }
    }

    // ConcreteFactory3
    class CanineFactory : IAbstractFactory
    {
        // Dog's factory
        public IEnemy CreateEnemy() { return new Wolf(); }
        public IRace CreateRace() { return new Canine(); }
    }

    #endregion

    #endregion


}
