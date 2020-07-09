using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_24_Challenges
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return  a + b;
        }
        public int Subtract(int a, int b)
        {
            return a - b;
        }
        public int Multiply(int a , int b)
        {
            return a * b;
        }
        public int Divide(int a , int b)
        {
            return a / b;
        }
    }

    public interface IKomodo
    {
        string VehicleType { get; }
        bool Start { get; }
        bool TurnOff { get; }
        bool Drive { get; }
        string Make { get; }
        string Model { get; }
    }

    public class SUV : IKomodo
    {
        public string VehicleType
        {
            get { return "SUV"; }
        }
        public bool Start
        {
            get { return true; }

        }
        public bool TurnOff
        {
            get { return false; }
        }
        public bool Drive
        {
            get { return true; }
        }
        public string Make
        {
            get { return "Motorcycle"; }
        }
        public string Model
        {
            get { return "Nice"; }
        }
    }
}
