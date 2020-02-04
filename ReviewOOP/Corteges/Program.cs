using System;

namespace Corteges
{
    class Program
    {
        static (string, int) ReturnResult((int, string) tuple, int num)
        {
            var result = (name: tuple.Item2, age: tuple.Item1 * num);
            return result;
        }
        static (int, int) RetTwoResult()
        {
            int result = 1;
            int result2 = 5;
            return (result, result2);
        }
        static int GetValue()
        {
            int result = 1;
            return result;
        }
        static void Main(string[] args)
        {
            //Example1();

            //Example2();

            //GetValue();

            //RetTwoResult();

            //ReturnResult(("Sam", 10), 2);

            Console.ReadKey();
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
