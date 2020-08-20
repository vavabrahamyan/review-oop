using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Tester t = new Tester();

            (t as IRoom).DoIt();

        }
        public static string Statement(string str)
        {
            string ret = "";
            for (int i = str.Length-1; i >= 0; i--)
            {
                ret += str[i];
            }
            return ret;
        } 
    }
}

            //about IEnumerable, ICollection and IList
            //IList is inherited of ICollection and IEnumerable
            //ICollection is inherited of IEnumerable 
                //Methodes and fields in IList
                     //Indexator, IsFixedSize, IsReadonly,
                     //Add(), Clear(), Contains(), IndexOf(),
                     //Insert(), Remove(), RemoveAt,
                //Methodes and fields in ICollection
                    //Count, IsSynchronized, SyncRoot
                    //CopyTo()
                //Methodes and fields in IEnumerable
                    //GetEnumerator(),

