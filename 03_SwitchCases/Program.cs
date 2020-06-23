using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_SwitchCases
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 1;
            switch (input)
            {
                case 1:
                    Console.WriteLine("Hello");
                    break;
                case 2:
                    Console.WriteLine("What are you doing?");
                    break;
                default:
                    Console.WriteLine("This is default. It will execute if no other casee is evaluated.");
                    break;
            }

            DayOfWeek today = DateTime.Today.DayOfWeek;
            switch (today)
            {
                case DayOfWeek.Monday:
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                case DayOfWeek.Friday:
                    Console.WriteLine("Hope you are ready to work!");
                    break;
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    Console.WriteLine("Sorry we are closed");
                    break;

                    //-- Challenge 
                    // Ask the user how they are feeling on a scale of 1-5. Capture their input and run it through a switch statement. Output a different response for each value. If they respond out of range, let me know. 
            }

        }
    }
}
