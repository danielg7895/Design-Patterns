using System;
using System.Collections.Generic;

namespace BuilderPattern
{
    class Builder
    {
        public void Main()
        {
            Director director = new Director();

            Console.WriteLine("----------------------------------");
            PotatoPC potatoPC = new PotatoPC();
            director.Construct(potatoPC);
            Console.WriteLine("----------------------------------\n");

            Console.WriteLine("----------------------------------");
            BudgetGamingPC budgetGamingPC = new BudgetGamingPC();
            director.Construct(budgetGamingPC);
            Console.WriteLine("----------------------------------\n");

            Console.WriteLine("----------------------------------");
            // A custom PC with 3 components
            CustomPC _customPC1 = new CustomPC();
            PC customPC1 = _customPC1
                .AddCoolers()
                .AddGraphicsCard()
                .AddProcessor()

                .Build();
            customPC1.ShowComponents();
            Console.WriteLine("----------------------------------\n");

            Console.WriteLine("----------------------------------");
            // A custom PC with 5 components
            CustomPC _customPC2 = new CustomPC();
            PC customPC2 = _customPC1
                .AddCoolers()
                .AddGraphicsCard()
                .AddRAM()
                .AddRGB()
                .AddProcessor()

                .Build();
            customPC2.ShowComponents();
            Console.WriteLine("----------------------------------\n");
        }
    }

    // "Director" class
    class Director
    {
        public void Construct(PCBuilder builder)
        {
            PC myPC = builder
                .AddCoolers()
                .AddGraphicsCard()
                .AddRAM()
                .AddPowerSupply()
                .AddRGB()
                .AddProcessor()
                .AddMotherBoard()
                .Build();

            myPC.ShowComponents();
        }
    }

    // "Product" class
    class PC
    {
        Dictionary<string, string> components = new Dictionary<string, string>();

        public string this[string key]
        {
            get { return components[key]; }
            set { components[key] = value; }
        }

        public void ShowComponents()
        {
            foreach(KeyValuePair<string, string> component in components)
            {
                Console.WriteLine($"{component.Key}: {component.Value}");
            }
        }
    }

    // Builder abstract class
    abstract class PCBuilder
    {
        protected PC _pc;
        
        public PC Build()
        {
            return _pc;
        }

        abstract public PCBuilder AddRAM();
        abstract public PCBuilder AddProcessor();
        abstract public PCBuilder AddGraphicsCard();
        abstract public PCBuilder AddCoolers();
        abstract public PCBuilder AddPowerSupply();
        abstract public PCBuilder AddRGB();
        abstract public PCBuilder AddMotherBoard();
    }

    // ConcreteBuilder 1
    class PotatoPC : PCBuilder
    {

        public PotatoPC()
        {
            _pc = new PC();
            _pc["description"] = "Potato PC";
        }

        public override PCBuilder AddRAM()
        {
            _pc["RAM"] = "1GB";

            return this;
        }

        public override PCBuilder AddProcessor()
        {
            _pc["processor"] = "Intel Celeron";

            return this;
        }

        public override PCBuilder AddGraphicsCard()
        {
            _pc["graphicsCard"] = "None";

            return this;
        }

        public override PCBuilder AddCoolers()
        {
            _pc["coolers"] = "Only the processor fan";

            return this;
        }

        public override PCBuilder AddPowerSupply()
        {
            _pc["powerSupply"] = "Generic NOGANET 400W";

            return this;
        }

        public override PCBuilder AddRGB()
        {
            _pc["rgb"] = "None. Adding rgb will burn the power supply.";

            return this;
        }

        public override PCBuilder AddMotherBoard()
        {
            _pc["motherboard"] = "Asrock H310cm-hdv 1151";

            return this;
        }
    }

    // ConcreteBuilder 2
    class BudgetGamingPC : PCBuilder
    {

        public BudgetGamingPC()
        {
            _pc = new PC();
            _pc["description"] = "Budget gaming PC";
        }

        public override PCBuilder AddRAM()
        {
            _pc["RAM"] = "16GB";

            return this;
        }

        public override PCBuilder AddProcessor()
        {
            _pc["processor"] = "Intel i5 10400f";

            return this;
        }

        public override PCBuilder AddGraphicsCard()
        {
            _pc["graphicsCard"] = "GeForce 1660 Super";

            return this;
        }

        public override PCBuilder AddCoolers()
        {
            _pc["coolers"] = "5 fans";

            return this;
        }

        public override PCBuilder AddPowerSupply()
        {
            _pc["powerSupply"] = "Corsair CV450";

            return this;
        }

        public override PCBuilder AddRGB()
        {
            _pc["rgb"] = "YES. Ram, fans and graphic card.";

            return this;
        }

        public override PCBuilder AddMotherBoard()
        {
            _pc["motherboard"] = "GIGABYTE h510";

            return this;
        }
    }

    // ConcreteBuilder 3 -- The real builder pattern, btw not the best example, something like build a pizza fits better
    class CustomPC : PCBuilder
    {

        public CustomPC()
        {
            _pc = new PC();
            _pc["description"] = "Custom PC";
        }

        public override PCBuilder AddRAM()
        {
            _pc["RAM"] = "Ram added";

            return this;
        }

        public override PCBuilder AddProcessor()
        {
            _pc["processor"] = "Proccessor added";

            return this;
        }

        public override PCBuilder AddGraphicsCard()
        {
            _pc["graphicsCard"] = "Graphics card added";

            return this;
        }

        public override PCBuilder AddCoolers()
        {
            _pc["coolers"] = "Fans added";

            return this;
        }

        public override PCBuilder AddPowerSupply()
        {
            _pc["powerSupply"] = "PowerSupply added";

            return this;
        }

        public override PCBuilder AddRGB()
        {
            _pc["rgb"] = "RGB added";

            return this;
        }

        public override PCBuilder AddMotherBoard()
        {
            _pc["motherboard"] = "Motherboard added";

            return this;
        }
    }

}
