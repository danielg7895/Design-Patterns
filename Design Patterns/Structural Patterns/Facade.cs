using System;
using System.Collections.Generic;
using System.Threading;

namespace FacadePattern
{
    class Facade
    {
        public void Main()
        {
            Skill dragonTail = new Skill("Dragon Tail", 200, 50);
            Skill dragonPower = new Skill("Dragon power", 50, 350);
            Skill shadowClaw = new Skill("Shadow Claw", 0, 300);
            Skill playRough = new Skill("Play Rough", 250, 0);
            List<Skill> skills = new List<Skill>() { shadowClaw, playRough, dragonPower, dragonTail };

            Pokemon dragonite = new Pokemon("Dragonite", 1400, 300, 300, 150, 250, 200, skills);
            Pokemon mimikyu = new Pokemon("Mimikyu", 2200, 220, 300, 150, 180, 250, skills);

            CombatSystem combatSystem = new CombatSystem(mimikyu, dragonite);
            combatSystem.Start();
        }
    }

    #region subsystem
    public class Skill
    {
        public string Name { get; set; }
        int Attack { get; set; }
        int SpecialAttack { get; set; }

        public Skill(string name, int attack, int specialAttack)
        {
            Name = name;
            Attack = attack;
            SpecialAttack = specialAttack;
        }

        public int GetAttackDamage(Pokemon pokemon)
        {
            return Attack + pokemon.Attack;
        }

        public int GetSpecialAttackDamage(Pokemon pokemon)
        {
            return SpecialAttack + pokemon.SpecialAttack;
        }
    }

    public class Pokemon
    {
        public string Name { get; set; }
        public int HP { get; set; }
        public int Defense { get; set; }
        public int Attack { get; set; }
        public int SpecialAttack { get; set; }
        public int SpecialDefense { get; set; }
        public int Speed { get; set; }
        public bool IsAlive { get; set; }  = true;
        public List<Skill> Skills { get; set; }

        public Pokemon(string name, int hp, int defense, int attack, int specialAttack, int specialDefense, int speed, List<Skill> skills)
        {
            Name = name;
            HP = hp;
            Defense = defense;
            Attack = attack;
            SpecialAttack = specialAttack;
            SpecialDefense = specialDefense;
            Speed = speed;
            Skills = skills;
        }

        public void PerformAttack(Pokemon pokemon)
        {
            int index = new Random().Next(Skills.Count);
            Skill randomSkill = Skills[index];
            pokemon.RecieveAttack(randomSkill, pokemon);
        }

        public void RecieveAttack(Skill skill, Pokemon pokemon)
        {
            int recievedADamage = skill.GetAttackDamage(pokemon) - Defense;
            int recievedSADamage = skill.GetSpecialAttackDamage(pokemon) - SpecialDefense;

            int totalDamage = recievedADamage + recievedSADamage;
            
            if (totalDamage > HP)
            {
                HP = 0;
                IsAlive = false;
            }
            else HP -= totalDamage;
        }
    }

    class CombatSystem
    {
        private readonly Pokemon _pokemon1;
        private readonly Pokemon _pokemon2;

        public CombatSystem(Pokemon pokemon1, Pokemon pokemon2)
        {
            _pokemon1 = pokemon1;
            _pokemon2 = pokemon2;
        }

        public void Start()
        {
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine($"The fight between {_pokemon1.Name} and {_pokemon2.Name} its about to start!");
            Console.WriteLine("---------------------------------------------------------");

            Pokemon firstPokemon = GetFirstAttacker();
            Pokemon secondPokemon = GetSecondAttacker();
            Console.WriteLine($"{firstPokemon.Name} attacks first.");

            int turn = 0;
            bool combatFinished = false;
            while (!combatFinished)
            {
                Console.WriteLine($"\n----------------- Turn {turn} starts -----------------");
                combatFinished = Attack(firstPokemon, secondPokemon);
                if (combatFinished)
                {
                    ShowPokemonsHP();
                    break;
                }
                combatFinished = Attack(secondPokemon, firstPokemon);

                ShowPokemonsHP();
                turn++;
                Thread.Sleep(4000);
            }
            Console.WriteLine("The combat has ended.");

        }

        public Pokemon GetFirstAttacker()
        {
            return _pokemon1.Speed >= _pokemon2.Speed ? _pokemon1 : _pokemon2;
        }

        public Pokemon GetSecondAttacker()
        {
            return _pokemon1.Speed >= _pokemon2.Speed ? _pokemon2 : _pokemon1;
        }

        public bool Attack(Pokemon attacker, Pokemon attacked)
        {
            Console.WriteLine($"{attacker.Name} attacks {attacked.Name}!");
            attacker.PerformAttack(attacked);

            if (!attacked.IsAlive)
            {
                Console.WriteLine($"{attacked.Name} fainted.");
                return true;
            }
            return false;
        }

        public void ShowPokemonsHP()
        {
            Console.WriteLine($"{_pokemon1.Name} HP: {_pokemon1.HP}");
            Console.WriteLine($"{_pokemon2.Name} HP: {_pokemon2.HP}");
        }
    }
    #endregion

}
