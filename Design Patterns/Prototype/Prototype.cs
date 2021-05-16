using System;

namespace PrototypePattern
{
    class Prototype
    {

        public void Main()
        {
            User user1 = new User()
            {
                Username = "Almond",
                Password = "A123",
                Description = "I'm a nut",
                IsAdmin = true
            };
            user1.ShowInfo();

            // Cloning user1 and changing some values
            User user2 = (User)user1.Clone();
            user2.Username = "Lentil";
            user2.Description = "I'm a Legume";
            user2.ShowInfo(); // same password and IsAdmin as user1

        }
    }

    // Prototype
    interface IPrototype
    {
        IPrototype Clone();
        public void ShowInfo();
    }


    // ConcretPrototype 1
    class User : IPrototype
    {
        public string Username;
        public string Password;
        public string Description;
        public bool IsAdmin;

        public IPrototype Clone()
        {
            return (User)MemberwiseClone(); // only top lvl objects are clonned.
        }

        public void ShowInfo()
        {
            Console.WriteLine($"username: {Username}, password: {Password}, description: {Description}, isAdmin: {IsAdmin}");
        }
    }



}
