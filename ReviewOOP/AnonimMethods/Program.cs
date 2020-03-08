using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonimMethods
{
    class Program
    {
        delegate void MessageHandler(string str);
        static void Main(string[] args)
        {
            Show("Hello World", delegate (string str)
            {
                Console.WriteLine(str + "!!!");
            });

        }

        static void Show(string mes, MessageHandler handler)
        {
            handler(mes);
        }
    }
}
