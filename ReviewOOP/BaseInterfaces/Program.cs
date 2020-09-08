using System;

namespace BaseInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person { Name = "Tom", Age = 27, Work = new Company { Name = "Microsoft" } };
            Person p2 = (Person)p1.Clone();
            //Person p3 = p1;
            p2.Name = "Alice";
            p2.Work = new Company { Name = "Google" };
            //p3.Name = "George";
            Console.WriteLine(p1.Name);
            Console.WriteLine(p1.Work.Name);
        }
    }
}
