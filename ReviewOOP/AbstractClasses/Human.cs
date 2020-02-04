using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses
{
    class Human
    {
        public string Name { get; set; }
    }
    abstract class Person
    {
        public string name;
        protected Person(string name, string surame)
        {
            Name = name;
            Surame = surame;
        }

        public abstract string Name { get; set; }
        public abstract string Surame { get; set; }
        public abstract void Display();
    }
    class Client:Person
    {
        public Client(string name, string surame, int sum) : base(name, surame)
        {
            Sum = sum;
        }

        public int Sum { get; set; }
        public override string Name { get; set; }
        public override string Surame { get; set; }

        public override void Display()
        {
            Console.WriteLine($"{Name}_{Surame} have {Sum} dollars"); ;
        }
    }
    class Employee:Person  
    {
        public Employee(string name, string surame) : base(name, surame)
        {
        }

        public string Position { get; set; }
        public override string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string Surame { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void Display()
        {
            throw new NotImplementedException();
        }
    }
}
