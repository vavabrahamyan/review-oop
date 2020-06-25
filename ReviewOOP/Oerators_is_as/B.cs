using System;
using System.Collections.Generic;
using System.Text;

namespace Oerators_is_as
{
    internal class B
    {
    }
    internal class D:B
    {

    }
    internal class C:B
    {
        internal int Id {get;set;}
        
        void Print()
        {
            Console.WriteLine($" This Id: {Id}");
        }
    }
}
