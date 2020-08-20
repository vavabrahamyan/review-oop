using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Interfaces
{
    public interface IRoom
    {
        private const int MaxSpeed = 90;
        public void DoIt()
        {
            Console.WriteLine("Good Morning");
        }
        public int GetSpeed()
        {
            return (MaxSpeed + 0)/2;
        }
    }
    interface IR : IRoom
    {
        public void DoIt();
    }
    class Room : IR
    {
        public void DoIt()
        {
            Console.WriteLine("Do it");
        }
    }
}
