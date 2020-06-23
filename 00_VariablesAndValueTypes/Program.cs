using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_VariablesAndValueTypes
{
    enum PastryType { Cake, Cupcake, Croissant, Donut, Cookie, Scone, Danish};
    class Program
    {
        static void Main(string[] args)
        {
            // Bools
            bool isDeclared;
            isDeclared = true;

            bool isDeclaredAndInitialized = false;
            isDeclaredAndInitialized = true;

            // Char
            char character = 'a';
            char symbol = '&';
            char number = '5';
            char space = ' ';
            char special = '\n';

            // Whole Numbers
            byte byteExample = 255;
            sbyte sByteExample = -128;
            short shortExample = 32767;
            Int16 anotherShortExample = 32000;
            int intMin = -2147483648;
            Int32 intMax = 2147483647;
            long longExample = 9223372036854775807;
            Int64 longMin = -9223372036854775808;

            int a = 7;
            int b = -7000;

            byte age = 104;

            // Decimals
            float floatExample = 1.045231f;
            double doubleExample = 1.789053278907036;
            decimal decimalExample = 1.25789072890457897897897897897897m;
            Console.WriteLine(1.25789072890457897897897897897897f);
            Console.WriteLine(1.25789072890457897897897897897897d);
            Console.WriteLine(1.25789072890457897897897897897897m);


            Console.ReadKey();

            // Enums

            PastryType myPastry = PastryType.Croissant;
            PastryType anotherOne = PastryType.Danish;

            //Structs

            Int32 num = 42;
            DateTime today = DateTime.Today;
            DateTime birthday = new DateTime(1995, 12, 30);
            DateTime test = new DateTime();

        }
    }
}
