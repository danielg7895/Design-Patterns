using System;

namespace FactoryMethodPattern
{
    class FactoryMethod
    {
        public void Main()
        {

            // In this case im using the enemy factory depending on the character lvl
            Console.WriteLine("WITH Factory Method - Spawning enemies depending on the character lvl:");
            ConcreteEnemyLvlFactory concreteEnemyLvlFactory = new ConcreteEnemyLvlFactory();
            IEnemy lvlEnemy = concreteEnemyLvlFactory.Build(60); // lvl 60 = gargola
            lvlEnemy.ShowName();
            Console.WriteLine();


            // Code with factory method, in this case im using the random enemy factory
            Console.WriteLine("WITH Factory Method - Random enemies!:");
            ConcreteEnemyRandomFactory concreteEnemyRandomFactory = new ConcreteEnemyRandomFactory();
            IEnemy randomEnemy = concreteEnemyRandomFactory.Build(60);
            randomEnemy.ShowName();
            Console.WriteLine();

        }

    }

    #region factory method

    public interface IEnemy
    {
        public abstract void ShowName();
    }

    public class Gremlin : IEnemy
    {
        public void ShowName()
        {
            Console.WriteLine("I'm a Gremlin, i'm going to kill you with my big stick!");
        }
    }

    public class Gargoyle : IEnemy
    {
        public void ShowName()
        {
            Console.WriteLine("I will stab my wings in your throat!");
        }
    }

    public class Wolf : IEnemy
    {
        public void ShowName()
        {
            Console.WriteLine("Woof wof wof wof wooofofofo foo!.");
        }
    }

    // Factory Method
    public abstract class EnemyFactory
    {
        public abstract IEnemy Build(int playerLVL);
    }

    public class ConcreteEnemyLvlFactory : EnemyFactory
    {
        // Factory that creates the enemy depending based on player's lvl
        public override IEnemy Build(int playerLVL)
        {
            if (playerLVL <= 10) return new Gremlin();
            if (playerLVL < 40)  return new Wolf();
            
            return new Gargoyle();
        }
    }

    public class ConcreteEnemyRandomFactory : EnemyFactory
    {
        // Factory that creates enemy randomly
        public override IEnemy Build(int playerLVL)
        {
            int randomNum = new Random().Next(0, 100);
            
            if (randomNum < 33) return new Gremlin();
            if (randomNum < 66) return new Wolf();

            return new Gargoyle();
        }
    }
    #endregion
}
