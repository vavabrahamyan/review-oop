using System;

namespace RefAndOut
{
    class Program
    {
        static void Main(string[] args)
        {
            //ref out

            //Examlple1();

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };

            ref int nRef = ref Find(numbers, 4);
            Console.WriteLine(numbers[3]);

            nRef = 45;
            Console.WriteLine(numbers[3]);

            Console.ReadKey();
        }
        static ref int Find(int[] numbers, int num)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == num)
                    return ref numbers[i];
            }
            throw new Exception("The num is not ...");
        }

        private static void Examlple1()
        {
            int x = 9;
            ref int xRef = ref x;
            Console.WriteLine($"x = {x}");
            Console.WriteLine($"xRef = {xRef}");

            xRef = 174;
            Console.WriteLine($"x = {x}");
        }
    }
}
