using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    interface IMovable
    {
        void Move();
    }
    abstract class Person
    {
        public  void Move()
        {
            Console.WriteLine("This is Move method from class Person ");
        }
    }
    //class User : Person, IMovable
    //{

    //}
    class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is Going");
        }
    }
}
