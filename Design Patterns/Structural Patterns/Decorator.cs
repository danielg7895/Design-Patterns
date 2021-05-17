namespace DecoratorPattern
{
    public class Decorator
    {
        public void Main() => new Client().Main();
    }

    public class Client
    {
        public void Main()
        {
            Monster cat = new Cat("Nino");
            Monster wolf = new Wolf("Richi");

            // making the monsters able to dance
            DancerMonster dancerCat = new DancerMonster(cat);
            DancerMonster dancerWolf = new DancerMonster(wolf);

            dancerCat.Attack();
            dancerCat.Dance();
            dancerCat.Die();

            System.Console.WriteLine("");

            dancerWolf.Attack();
            dancerWolf.Dance();
            dancerWolf.Die();
        }
    }
    
    // Component
    public abstract class Monster
    {
        public string Name { get; set; }

        public Monster(string name) => Name = name;

        public abstract void Attack();
        public void Die() => System.Console.WriteLine($"{Name} is dead :(");
    }

    // ConcreteComponent
    public class Wolf : Monster
    {
        public Wolf(string name) : base(name) { }

        public override void Attack()
        {
            System.Console.WriteLine($"{Name} attacks with her fang");
        }
    }

    public class Cat : Monster
    {
        public Cat(string name) : base(name) { }

        public override void Attack()
        {
            System.Console.WriteLine($"{Name} attacks with her paw");
        }
    }

    public abstract class DecoratorPattern : Monster
    {
        protected Monster _monster;

        public DecoratorPattern(Monster monster) : base(monster.Name)
        {
            _monster = monster;
        }

        public abstract void Dance();
        
        public override void Attack()
        {
            _monster.Attack();
        }
    }

    public class DancerMonster : DecoratorPattern
    {
        public DancerMonster(Monster monster) : base(monster) { }

        public override void Dance()
        {
            System.Console.WriteLine($"{_monster.Name} starts dancing!");
        }
    }


}
