using System;
using System.Collections.Generic;
using System.Text;

namespace BaseInterfaces
{
    class Person : ICloneable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Company Work { get; set; }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
    class Company
    {
        public string Name { get; set; }
    }
}
