using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    interface IAction
    {
        void Move();
    }
    class BaseAction : IAction
    {
        public virtual void Move()
        {
            Console.WriteLine("Move in BaseAction");
        }
    }
    class HeroAction : BaseAction
    {
        public override void Move()
        {
            Console.WriteLine("Move in HeroAction");
        }
    }
}
