using System;

namespace BaseInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person p1 = new Person { Name = "Tom", Age = 27, Work = new Company { Name = "Microsoft" } };
            //Person p2 = (Person)p1.Clone();
            ////Person p3 = p1;
            //p2.Name = "Alice";
            //p2.Work = new Company { Name = "Google" };
            ////p3.Name = "George";
            //Console.WriteLine(p1.Name);
            //Console.WriteLine(p1.Work.Name);

            Man m1 = new Man { Name = "Bill", Age = 44 };
            Man m2 = new Man { Name = "Stive", Age = 34 };
            Man m3 = new Man { Name = "Alice", Age = 17 };

            Man[] men = new Man[] { m1, m2, m3 };
            Array.Sort(men);
            foreach (var m in men)
            {
                Console.WriteLine($"{m.Name} __ {m.Age}");
            }
            Console.Read();
        }
    }
}
