using System;
using System.Text;

namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            // String
            String s = "Hi there.";

            // Encoding object
            Encoding encodingUTF8 = Encoding.UTF8;

            // Encode string to byte array
            byte[] encodedBytes = EncodingMethod(s, encodingUTF8);
            Console.WriteLine("Encoded bytes: " +
                              BitConverter.ToString(encodedBytes));

            // Decode to string
            string decodedString = DecodeMethod(encodingUTF8, encodedBytes);
            Console.WriteLine("Decoded string: " + decodedString);


            //Method();
            Console.ReadLine();
        }

        private static string DecodeMethod(Encoding encodingUTF8, byte[] encodedBytes)
        {
            return encodingUTF8.GetString(encodedBytes);
        }

        private static byte[] EncodingMethod(string s, Encoding encodingUTF8)
        {
            return encodingUTF8.GetBytes(s);
        }

        static void Method()
        {
            //int i = 5;
            //long l = (long)i;

            //Console.WriteLine(l);


            //UserInfo ui_1 = new UserInfo("Vahe", 25);
            //UserInfo ui_2 = new UserInfo("Mariam", 20);

            //ui_1.Display();
            //ui_2.Display();

            //Console.WriteLine("After change");
            //ui_2 = ui_1;

            //ui_1.Name = "Mariamcho";
            //ui_1.Age = 19;

            //ui_1.Display();
            //ui_2.Display();
        }
    }
}
