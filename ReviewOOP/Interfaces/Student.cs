using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Interfaces
{
    public interface IHome
    {
        public void DoIt();
    }
    public interface IRoom
    {
        public void DoIt();

        public int MyFoo()
        {
            Console.WriteLine("This is my Function");
            return 7;
        }
    }
    interface IR : IRoom
    {
        public new void DoIt();
    }
    class Room : IRoom, IHome
    {
        public void DoIt()
        {
            Console.WriteLine("Do");
        }
    }
    public class Tester: IRoom, IHome
    {
          void IRoom.DoIt()
        {
            Console.WriteLine("IRoom.DoIt()");
        }
          void IHome.DoIt()
        {
            Console.WriteLine("IHome.DoIt()");
        }
    }
}
