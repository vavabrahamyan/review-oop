using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

}
