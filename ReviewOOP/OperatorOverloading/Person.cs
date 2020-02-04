using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorOverloading
{
    class Person
    {
        public decimal Rate { get; set; }

        public Person(decimal rate)
        {
            Rate = rate;
        }

        public static implicit operator Person(decimal d)
        {
            return new Person(d);
        }

        public static explicit operator decimal(Person p)
        {
            return p.Rate;
        }
    }
}
