using System;

namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInfo ui_1 = new UserInfo("Vahe", 25);
            UserInfo ui_2 = new UserInfo("Mariam", 20);

            ui_1.Display();
            ui_2.Display();

            Console.WriteLine("After change");
            ui_2 = ui_1;

            ui_1.Name = "Mariamcho";
            ui_1.Age = 19;

            ui_1.Display();
            ui_2.Display();
        }
    }
}
