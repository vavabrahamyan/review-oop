using System;

namespace Structs
{
    struct User
    {
        public User(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }

        public string name { get; set; }
        public string surname { get; set; }
        public int age { get; set; }

        public void Show()
        {
            System.Console.WriteLine($"User:{name}_{surname} is {age} years old");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            //Example1();
        }

        private static void Example1()
        {
            User[] users = { new User("Vahe", "Abrahamyan", 25), new User("Vahe", "Abrahamyan", 25),
                new User("Vahe", "Abrahamyan", 25), new User("Vahe", "Abrahamyan", 25), new User("Vahe", "Abrahamyan", 25) };

            foreach (User u in users)
            {
                u.Show();
            }
            Console.ReadLine();
        }
    }
}
