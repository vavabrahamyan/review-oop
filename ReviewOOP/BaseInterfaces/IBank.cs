using System;
using System.Collections.Generic;
using System.Text;

namespace BaseInterfaces
{
    interface IBank< out T>
    {
        public T CreateAccount(int sum);
    }
    class Bank<T> : IBank<T> where T : Account, new()
    {
        public T CreateAccount(int sum)
        {
            T acc = new T();
            acc.DoTransfer(sum);
            return acc;
        }
    }
}
