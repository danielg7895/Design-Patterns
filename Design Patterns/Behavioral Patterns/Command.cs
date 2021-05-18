using System;


namespace CommandPattern
{
    class Command
    {
        public void Main()
        {
            string document = "{\"_id\": 44, \"name\": \"Joe\"}";
            Database database = new Database();

            Console.WriteLine("");
            AddCommand addCommand = new AddCommand(database);
            addCommand.Execute(document);

            Console.WriteLine("");
            GetCommand getCommand = new GetCommand(database);
            getCommand.Execute(document);

            Console.WriteLine("");
            RemoveCommand removeCommand = new RemoveCommand(database);
            removeCommand.Execute(document);

            Console.WriteLine("");
            UpdateCommand updateCommand = new UpdateCommand(database);
            updateCommand.Execute(document);
        }

    }

    public class Database
    {

        public void Add(string document)
        {
            Console.WriteLine($"ADD -> {document} completed.");

        }

        public void Remove(string document)
        {
            Console.WriteLine($"REMOVE -> {document} completed.");

        }

        public void Update(string document)
        {
            Console.WriteLine($"UPDATE -> {document} completed.");
        }

        public void Get(string document)
        {
            Console.WriteLine($"GET -> {document} completed.");
        }

    }

    public abstract class DatabaseCommand
    {
        protected Database _database;

        public DatabaseCommand(Database database)
        {
            _database = database;
        }

        public abstract void Execute(string document);
    }

    public class AddCommand : DatabaseCommand
    {
        public AddCommand(Database database) : base(database) { }

        public override void Execute(string document)
        {
            _database.Add(document);
        }
    }

    public class UpdateCommand : DatabaseCommand
    {
        public UpdateCommand(Database database) : base(database) { }

        public override void Execute(string document)
        {
            _database.Update(document);
        }
    }

    public class RemoveCommand : DatabaseCommand
    {
        public RemoveCommand(Database database) : base(database) { }

        public override void Execute(string document)
        {
            _database.Remove(document);
        }
    }

    public class GetCommand : DatabaseCommand
    {
        public GetCommand(Database database) : base(database) { }

        public override void Execute(string document)
        {
            _database.Get(document);
        }
    }
}

