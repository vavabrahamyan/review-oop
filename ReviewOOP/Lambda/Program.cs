using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        delegate int Operation(int x, int y);
        public delegate void Deleg();
        public delegate void Display(string str);
        static void Main(string[] args)
        {
            int[] nums = new int[20] ;
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = i;
            }
            var squareNumbers = nums.Select(x => x * x);
            Console.WriteLine(string.Join("/", squareNumbers));

            //Account account = new Account(100);
            //account.Added += (sender, e) =>
            //{
            //    Console.WriteLine(e.Sum);
            //    Console.WriteLine(e.Message);
            //};

            //account.Put(100);
            //account.Put(203);


            //Display display = (p) => Console.WriteLine(p.ToString());
            //display("Hello World");

            //Deleg d = () => Console.WriteLine("Hello axper jan");
            //d.Invoke();
            //Operation op1 = (x, y) => x + y;
            //int z = op1(11, 111);
        }
    }
}
