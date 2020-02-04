using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //try...catch...finally

            int[] nums = new int[4];
            nums[4] = 10;//Error 

            try
            {
                nums[4] = 10;
                Console.WriteLine("End of try block");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error 404: {ex.Message}");
                Console.WriteLine($"temporary problems...");
            }
            finally
            {
                Console.WriteLine($"Block finally");
            }


            Console.ReadKey();
        }
    }
}
