using System;
using System.Collections.Generic;
using System.Text;

namespace BaseInterfaces
{
    class Man:IComparable
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public int CompareTo(object obj)
        {
            Person p = obj as Person;
            if(p != null)
            {
                return this.Name.CompareTo(p.Name);
            }
            else
            {
                Console.WriteLine("Error 444");
                return -1;
            }
        }
    }
}
