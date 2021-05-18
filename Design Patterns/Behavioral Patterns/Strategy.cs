using System;
using System.Collections.Generic;

namespace StrategyPattern
{
    public class Strategy
    {
        public void Main()
        {
            List<Pokemon> pokemons = new List<Pokemon>()
            {
                new Pokemon("Pikachu", 77, PokemonType.ELECTRIC),
                new Pokemon("Totodile", 40, PokemonType.WATER),
                new Pokemon("Flareon", 76, PokemonType.FIRE),
                new Pokemon("Silveon", 12, PokemonType.FAIRY),
                new Pokemon("Mega Charizard X", 44, PokemonType.DRAGON),
                new Pokemon("Delcatty", 66, PokemonType.NORMAL),
                new Pokemon("Magnetric", 99, PokemonType.ELECTRIC),
                new Pokemon("Yanmega", 77, PokemonType.BUG),
                new Pokemon("Unfezant", 100, PokemonType.FLYING),
                new Pokemon("Darmanitan", 71, PokemonType.FIRE),
                new Pokemon("Emolga", 16, PokemonType.ELECTRIC),
                new Pokemon("Haxorus", 35, PokemonType.DRAGON),
                new Pokemon("Tyrantrum", 47, PokemonType.ROCK),
                new Pokemon("Nihelgo", 89, PokemonType.ROCK),
                new Pokemon("Calyrex", 77, PokemonType.PSYCHIC),
                new Pokemon("DragaPult", 26, PokemonType.DRAGON),
                new Pokemon("Zamazenta", 49, PokemonType.FIGHTING),
                new Pokemon("Litten", 5, PokemonType.FIRE),
                new Pokemon("Rowlet", 15, PokemonType.GRASS),
            };

            SortedList byLvl = new SortedList(new SortByLvlStrategy(77), pokemons);
            SortedList byType = new SortedList(new SortByTypeStrategy(PokemonType.FIRE), pokemons);

            Console.WriteLine("\n---------------------- SORT BY LVL ----------------------");
            byLvl.Sort();
            byLvl.ShowList();

            Console.WriteLine("\n---------------------- SORT BY TYPE ----------------------");
            byType.Sort();
            byType.ShowList();

        }
    }

    public enum PokemonType
    {
        ROCK,
        STEEL,
        GHOST,
        ICE,
        FAIRY,
        GRASS,
        WATER,
        DRAGON,
        NORMAL,
        POISON,
        DARK,
        GROUND,
        FIRE,
        PSYCHIC,
        BUG,
        ELECTRIC,
        FIGHTING,
        FLYING
    }

    public class Pokemon
    {
        public string Name { get; set; }
        public int Lvl = 1;
        public PokemonType Type;

        public Pokemon(string name, int lvl, PokemonType type)
        {
            Name = name;
            Lvl = lvl;
            Type = type;
        }
    }

    // strategy
    public interface IStrategy
    {
        public void Sort(ref List<Pokemon> pokemonList);
    }

    // ConcreteStrategyA
    public class SortByTypeStrategy : IStrategy
    {
        PokemonType _type;

        public SortByTypeStrategy(PokemonType type) => _type = type;

        public void Sort(ref List<Pokemon> pokemonList)
        {
            List<Pokemon> pokesByType = new List<Pokemon>();

            pokemonList.ForEach(pokemon =>
            {
                if (pokemon.Type == _type)
                {
                    pokesByType.Add(pokemon);
                }
            });

            pokemonList = pokesByType;
        }
    }

    // ConcreteStrategyB
    public class SortByLvlStrategy : IStrategy
    {
        int _lvl;
        public SortByLvlStrategy(int lvl) => _lvl = lvl;

        public void Sort(ref List<Pokemon> pokemonList)
        {
            List<Pokemon> pokesByLvl = new List<Pokemon>();

            pokemonList.ForEach(pokemon =>
            {
                if (pokemon.Lvl == _lvl)
                {
                    pokesByLvl.Add(pokemon);
                }
            });

            pokemonList = pokesByLvl;
        }
    }

    // Context
    public class SortedList
    {
        private IStrategy _strategy;
        private List<Pokemon> _pokemonList;

        public SortedList(IStrategy strategy, List<Pokemon> pokemonList)
        {
            _strategy = strategy;
            _pokemonList = pokemonList;
        }

        public void Sort()
        {
            _strategy.Sort(ref _pokemonList);
        }

        public void ShowList()
        {
            _pokemonList.ForEach(pokemon =>
            {
                Console.WriteLine($"Pokemon: {pokemon.Name}, Lvl: {pokemon.Lvl}, Pokemon Type: {pokemon.Type}");
            });
        }


    }
}
