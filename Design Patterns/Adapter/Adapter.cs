namespace AdapterPattern
{
    public class Adapter
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
            Monster monster = new Monster()
            {
                Name = "Killer bunny",
                BaseHp = 500,
                BaseMp = 200,
                CON = 5,
                MEN = 3,
                Lvl = 40
            };

            ITarget adaptor = new MonsterAdapter(monster);
            adaptor.ShowMonsterStats();
        }
    }

    // Target
    public interface ITarget
    {
        public void ShowMonsterStats();
    }

    // Adaptor
    class MonsterAdapter : ITarget
    {
        private readonly Monster _monster;

        public MonsterAdapter(Monster monster)
        {
            _monster = monster;
        }

        public void ShowMonsterStats()
        {

            int maxHp = _monster.GetMaxHp();
            int maxMp = _monster.GetMaxMP();

            System.Console.WriteLine($"{_monster.Name} stats:\nMax HP: {maxHp}\nMax MP:{maxMp}");
        }

    }

    // Adaptee
    public class Monster
    {
        public string Name { get; set; }
        public int Lvl { get; set; }
        public int BaseHp { get; set; }
        public int BaseMp { get; set; }
        public int CON { get; set; }
        public int MEN { get; set; }

        public int GetMaxHp()
        {
            return BaseHp + Lvl * CON;
        }

        public int GetMaxMP()
        {
            return BaseMp + Lvl * MEN;
        }
    }
}
