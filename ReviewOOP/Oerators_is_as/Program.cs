using System;

namespace Oerators_is_as
{
    class Program
    {
        static void Main(string[] args)
        {
            //Object e = new Employee("MyName");
            //Manager m = new Manager("MyManagerName");
            //Employee e1 = e as Employee;
            //Console.WriteLine(e1.Name);

            Object o1 = new Object();
            Object o2 = new B();
            Object o3 = new D();
            Object o4 = o3;
            B b1 = new B();
            B b2 = new D();
            D d1 = new D();
            //B b3 = new Object()    // Compile time error
            //B b3 = new Object();   // Compile time error
            B b4 = d1;
            //D d3 = b2;             // Compile time error
            D d4 = (D)d1;
            D d5 = (D)b2;
            D d6 = (D)b1;            // Run time error
            B b5 = (B)o1;            // Run time error
            B b6 = (D)b2;

            Console.ReadLine();
        }
    }
}
