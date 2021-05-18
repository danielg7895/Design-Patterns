using System;
using System.Collections.Generic;

namespace MediatorPattern
{
    public class Mediator
    {
        public void Main()
        {
            IMediator mediator = new PingMediator();

            Argentina arg = new Argentina("Argentina", mediator);
            Venezuela ven = new Venezuela("Venezuela", mediator);
            Spain spain = new Spain("Spain", mediator);

            mediator.AddCountry(arg);
            mediator.AddCountry(ven);
            mediator.AddCountry(spain);

            mediator.Ping(arg, spain);
            Console.WriteLine("");

            mediator.Ping(arg, ven);
            Console.WriteLine("");

            mediator.Ping(spain, ven);
            Console.WriteLine("");

        }
    }

    public interface IMediator
    {
        public void AddCountry(Country country);
        public void Ping(Country reciever, Country sender);
    }

    public class PingMediator : IMediator
    {
        List<Country> countries = new List<Country>();

        public void AddCountry(Country country)
        {
            countries.Add(country);
        }

        public void Ping(Country reciever, Country sender)
        {
            countries.ForEach(country =>
            {
                if (country == reciever)
                {
                    country.Ping(sender);
                }
            });
        }
    }

    public abstract class Country
    {
        public string Name { get; set; }
        protected IMediator _mediator;

        public Country(string name, IMediator mediator)
        {
            Name = name;
            _mediator = mediator;
        }
        public void Ping(Country from)
        {
            Console.WriteLine($"{Name}: I recieved a ping from {from.Name}, sending pong!");
            from.Pong(this);
        }

        public void Pong(Country from)
        {
            Console.WriteLine($"{Name}: I recieved a pong from {from.Name}");
        }
    }

    public class Argentina : Country
    {
        public Argentina(string name, IMediator mediator) : base(name, mediator) { }

    }

    public class Venezuela : Country
    {
        public Venezuela(string name, IMediator mediator) : base(name, mediator) { }

    }

    public class Spain : Country
    {
        public Spain(string name, IMediator mediator) : base(name, mediator) { }

    }
}
