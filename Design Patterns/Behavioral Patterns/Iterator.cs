using System;
using System.Collections.Generic;

namespace IteratorPattern
{
    public class Iterator
    {

        public void Main()
        {
            Collection collection = new Collection();
            collection[0] = new Pokemon("Totodile");
            collection[1] = new Pokemon("Snorlax");
            collection[2] = new Pokemon("Tortoise");
            collection[3] = new Pokemon("Rayquaza");
            collection[4] = new Pokemon("Deoxis");

            IIterator iterator = new ConcreteIterator(collection);
            
            while (!iterator.IsDone())
            {
                Pokemon pokemon = iterator.Next<Pokemon>();
                if (pokemon != null)
                    Console.WriteLine(pokemon.Name);
            }
        }
    }
    public class Pokemon
    {
        public string Name { get; set; }

        public Pokemon(string name)
        {
            Name = name;
        }
    }

    public interface IAggregate
    {
        public ConcreteIterator CreateIterator();
    }

    public class Collection : IAggregate
    {
        private List<object> _items = new List<object>();

        public int Count()
        {
            return _items.Count;
        }

        public object this[int index]
        {
            get { return _items[index]; }
            set { _items.Add(value); }
        }

        public ConcreteIterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }
    }

    public interface IIterator
    {
        public T First<T>() where T : class;
        public T Next<T>() where T : class;
        public bool IsDone();
        public T CurrentItem<T>() where T : class;
    }

    public class ConcreteIterator : IIterator
    {
        private Collection _collection;
        private int _current = -1;

        public ConcreteIterator(Collection collection)
        {
            _collection = collection;
        }

        public T CurrentItem<T>() where T : class
        {
            return (T)_collection[_current];
        }

        public T First<T>() where T : class
        {
            return (T)_collection[0];
        }

        public bool IsDone()
        {
            return _current >= _collection.Count();
        }

        public T Next<T>() where T : class
        {
            _current += 1;
            if (!IsDone())
            {
                return (T)_collection[_current];
            }
            return null;
        }
    }
}
