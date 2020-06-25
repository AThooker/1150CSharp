using System;
using System.ComponentModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _05_Methods
{
    [TestClass]
    public class MethodExamples
    {
        [TestMethod]
        public void MethodExecution()
        {
            SayHello("Eric");
            SayHello("Harry");

            int inputOne = 7;
            int inputTwo = 13;
            int sum = AddTwoNumbers(inputOne, inputTwo);
            Console.WriteLine(sum);

            double doubleSum = AddTwoNumbers(242.2d, 234.5d);

            int myAge = CalculateAge(new DateTime(1995, 12, 30));
            Console.WriteLine("My age is: " + myAge);
        }
        public void SayHello(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }

        public int AddTwoNumbers(int numOne, int numTwo)
        {
            int sum = numOne + numTwo;
            return sum;
        }

        public double AddTwoNumbers(double one, double two)
        {
            double sum = one + two;
            return sum;
        }

        private int CalculateAge(DateTime birthday)
        {
            TimeSpan ageSpan = DateTime.Now - birthday;
            double totalAgeInYears = ageSpan.TotalDays / 365.25;
            int years = Convert.ToInt32(Math.Floor(totalAgeInYears));
            return years;
        }
    }
}
