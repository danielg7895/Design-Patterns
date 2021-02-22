using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    class Singleton
    {
        public void Main() => SingletonClass.Instance.ShowMessage();
    
    }

    class SingletonClass
    {
        static SingletonClass _Instance = null;
        public static SingletonClass Instance {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new SingletonClass();
                }
                return _Instance;
            }
        }

        public void ShowMessage() => Console.WriteLine("hey!");
    }


}
