using System;
using System.ComponentModel;
using _6_24_Challenges;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _6_24_Challenge_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalculatorTests()
        {
            Calculator calcTests = new Calculator();
            calcTests.Add(5, 76);
            calcTests.Subtract(10, 6);
            calcTests.Multiply(100, 5);
            calcTests.Divide(400, 20);
        }
    }
}
