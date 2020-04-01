using System;
using System.Collections.Generic;
using System.Text;

namespace Oerators_is_as
{
    class Employee
    {
        public Employee()
        {

        }
        public Employee(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
    }

    internal class Manager : Employee
    {
        public string Surname { get; set; }
        public Manager(string name) : base(name)
        {
        }
    }
}
