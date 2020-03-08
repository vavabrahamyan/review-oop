using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    delegate void AccountStateHandler(object sender, AccountEventArgs e);
    class Account
    {
        int _sum;

        public Account(int sum)
        {
            _sum = sum;
        }

        public event AccountStateHandler Added;
        public event AccountStateHandler Withdrawn;

        public void Put(int sum)
        {
            _sum += sum;
            if (Added != null)
                Added(this, new AccountEventArgs($"In balance added {sum}", sum));
        }
        public void Withdraw(int sum)
        {
            if(_sum >= sum)
            {
                _sum -= sum;
                if (Withdrawn != null)
                    Withdrawn(this, new AccountEventArgs($"Withdraw of balance{sum}", sum));

            }
        }
    }
    class AccountEventArgs
    {
        public string Message { get; }
        public int Sum { get; }
        public AccountEventArgs(string message, int sum)
        {
            Message = message;
            Sum = sum;
        }
    }
}
