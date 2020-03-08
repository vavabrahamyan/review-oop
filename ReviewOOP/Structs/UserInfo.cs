using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    struct UserInfo
    {
        public string Name;
        public byte Age;

        public UserInfo(string name, byte age)
        {
            Name = name;
            Age = age;
        }
        public void Display()
        {
            Console.WriteLine($"{Name} is {Age} years old");
        }
    }
}
