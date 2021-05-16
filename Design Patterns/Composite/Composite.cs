using System;
using System.Collections.Generic;

namespace CompositePattern
{
    public class Composite
    {
        public void Main()
        {
            new Client().Main();
        }
    }

    public class Client
    {
        public void Main()
        {
            CompositeFolder rootFolder = new CompositeFolder("Design Patterns");

            CompositeFolder comp1 = new CompositeFolder("Creational Patterns");
            comp1.Add(new Folder("Abstract Factory"));
            comp1.Add(new Folder("Factory Method"));
            comp1.Add(new Folder("Builder"));
            comp1.Add(new Folder("Prototype"));
            comp1.Add(new Folder("Singleton"));

            CompositeFolder comp2 = new CompositeFolder("Structural Patterns");
            comp2.Add(new Folder("Adapter"));
            comp2.Add(new Folder("Composite"));
            comp2.Add(new Folder("Decorator"));
            comp2.Add(new Folder("Facade"));
            comp2.Add(new Folder("Proxy"));

            CompositeFolder comp3 = new CompositeFolder("Behavioral Patterns");
            comp3.Add(new Folder("Iterator"));
            comp3.Add(new Folder("Observer"));
            comp3.Add(new Folder("Template Method"));
            comp3.Add(new Folder("State"));
            comp3.Add(new Folder("Strategy"));
            comp3.Add(new Folder("Chain of Responsability"));
            comp3.Add(new Folder("Command"));
            comp3.Add(new Folder("Mediator"));


            rootFolder.Add(comp1);
            rootFolder.Add(comp2);
            rootFolder.Add(comp3);

            rootFolder.Show(0); // show from root
        }
    }

    public abstract class Component
    {
        public string Name { get; set; }
        public Component (string name)
        {
            Name = name;
        }
        public abstract void Add(Component component);
        public abstract void Show(int index);
        public abstract void Remove(Component component);
    }

    // leaf
    public class Folder : Component
    {
        public Folder(string name) : base(name) { }

        public override void Add(Component component)
        {
            Console.WriteLine("Leaf cannot add components!");
        }

        public override void Remove(Component component)
        {
            Console.WriteLine("Leaf cannot remove components!");
        }

        public override void Show(int index)
        {
            Console.WriteLine($"{new string('-', index)}{Name}");
        }
    }

    // composite
    public class CompositeFolder : Component
    {
        public List<Component> components = new List<Component>();

        public CompositeFolder(string name) : base(name) { }

        public override void Add(Component component)
        {
            components.Add(component);
        }

        public override void Remove(Component component)
        {
            component.Remove(component);
        }

        public override void Show(int index)
        {
            Console.WriteLine($"{new string('-', index)}{Name}");
            index++;
            components.ForEach(component =>
            {
                component.Show(index);
            });
        }
    }
}
