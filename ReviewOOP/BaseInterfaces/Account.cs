using System;
using System.Collections.Generic;
using System.Text;

namespace BaseInterfaces
{
    class Account
    {
        public virtual void DoTransfer(int sum)
        {
            Console.WriteLine($"The client deposited { sum} dollars");
        }        
    }
    class DepositAccont: Account
    {
        public override void DoTransfer(int sum)
        {
            Console.WriteLine($"The client deposited <<DA>> {sum} dollars");
        }
    }
}
