using System;

namespace OperatorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person(7);
            decimal d = 78;
            d = (decimal)p;
            Console.WriteLine(d.ToString());
        }
    }
}
