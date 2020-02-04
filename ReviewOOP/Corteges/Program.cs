using System;

namespace Corteges
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example1();

            //Example2();
        }

        private static void Example2()
        {
            var (name, age) = ("Jerry", 7);
            Console.WriteLine(name);
            Console.WriteLine(age);
        }

        private static void Example1()
        {
            var cort = ("Vahe", 'A');
            cort.Item1 = "Tom";
            cort.Item2 = '?';

            Console.WriteLine($"We view new values. Value1;{cort.Item1}   Value2:{cort.Item2}");
            Console.ReadLine();
        }
    }
}
