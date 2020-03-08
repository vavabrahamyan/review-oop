using System;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("V", "A");
            emp.Name = "Vahe";
            emp.Surame = "Abrahamyan";
            emp.Display();
        }
    }
}
