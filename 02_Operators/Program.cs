using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 20;
            int b = 2;
            //Addition
            int sum = a + b;
            Console.WriteLine(sum);

            //Subtraction
            int difference = a - b;
            Console.WriteLine(difference);

            //Mulitiplication
            int product = a * b;
            Console.WriteLine(product);

            //Division
            int quotient = a / b;
            Console.WriteLine(quotient);

            //Remainder
            int remainder = a % b;
            Console.WriteLine(remainder);

            DateTime now = DateTime.Now;
            DateTime someDay = new DateTime(1842, 1, 1);
            TimeSpan timeSpan = now - someDay;
            Console.WriteLine(timeSpan);


            // Comparison Operators 
            Console.WriteLine("Enter your age");
            string ageString = Console.ReadLine();
            int age = int.Parse(ageString);
            Console.WriteLine("Enter your name:");
            string userName = Console.ReadLine();
            bool equals = age == 41;
            bool userIsFrank = userName == "Frank";
            Console.WriteLine("User is 41" + " " + equals);
            Console.WriteLine("User is Frank" +" "+ userIsFrank);

            bool notEqual = age != 113;
            bool userIsNotJustin = userName != "Justin";
            Console.WriteLine($"User is not 113: {notEqual}");
            Console.WriteLine($"User is not Justin: {userIsNotJustin}");

            List<string> firstList = new List<string>();
            firstList.Add(userName);

            List<string> secondList = new List<string>();
            secondList.Add(userName);

            bool listsAreEqual = firstList == secondList;
            Console.WriteLine(listsAreEqual);

            bool greaterThan = age > 12;
            bool greatThanOrEqual = age >= 55;
            bool lessThan = age < 1;
            bool lessThanOrEqual = age <= 99;

            bool orValue = equals || lessThan;

            bool tOrT = true || true;
            bool tOrF = true || false;
            bool fOrT = false || true;
            bool fOrF = false || false;

            bool andValue = greaterThan && orValue;
            bool tAndT = true && true;
            bool tAndF = true && false;
            bool fAndT = false && true;
            bool fAndF = false && false;
            int x = 3;
            bool test = x < 44 && x > 10;


            Console.ReadKey();



        }
    }
}
