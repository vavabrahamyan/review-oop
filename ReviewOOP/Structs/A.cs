using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    struct A:IEnumerable
    {
        private int num;
        public A(int _num)
        {
            num = _num;
        }
        public int Num { 
            get
            {
                return num;
            }
            set
            {
                num = value;
            }
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < 10; i++)
            {
                yield return i;
            }
        }

        public void Show()
        {
            Console.WriteLine(Num);
        }
    }
}
