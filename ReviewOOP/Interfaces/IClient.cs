using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    interface IAccount
    {
        int CurrentSum { get; }
        void Put(int sum);
        void Withdraw(int sum);
    }
    interface IClient
    {
        public string Name { get; set; }
    }
    class Client : IAccount, IClient
    {
        int _sum;

        public Client(int sum, string name)
        {
            _sum = sum;
            Name = name;
        }

        public string Name { get; set; }

        public int CurrentSum => _sum;

        public void Put(int sum)
        {
            _sum += sum;
        }

        public void Withdraw(int sum)
        {
            if(sum <= _sum)
            {
                _sum -= sum;
            }
        }
    }
    class Transaction<T> where T : IAccount, IClient
    {
        public void Operate(T acc1, T acc2, int sum)
        {
            if (acc1.CurrentSum >= sum)
            {
                acc1.Withdraw(sum);
                acc2.Put(sum);
                Console.WriteLine($"{acc1.Name} : {acc1.CurrentSum}\n{acc2.Name} : {acc2.CurrentSum}");
            }
        }
    }
}
