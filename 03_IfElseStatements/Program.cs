using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_IfElseStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            bool userIsHungry = true;
            if(userIsHungry)
            {
                Console.WriteLine("Eat Something!");
            }

            int hourSpentStudying = 1;
            if(hourSpentStudying < 16)
            {
                Console.WriteLine("Are you even trying?");
            }

            bool choresAreDone = false;
            if(choresAreDone)
            {
                Console.WriteLine("Have fun playing video games");
            }
            else
            {
                Console.WriteLine("Finish your chores");
            }

            Console.WriteLine("How many hours did you sleep?");
            string input = Console.ReadLine();
            int totalHours = int.Parse(input);

            if(totalHours >= 8)
            {
                Console.WriteLine("Congrats, you are living the dream");

            }
            else
            {
                Console.WriteLine("Go to sleep ya filthy animal");
                if(totalHours < 3)
                {
                    Console.WriteLine("Shape it up dawg");
                }
            }

            Console.WriteLine("How old are you?");
            string ageInput = Console.ReadLine();
            int age = Convert.ToInt32(ageInput);

            if(age > 17)
            {
                Console.WriteLine("Congrats on being an adult, not!!");

            }
            else
            {
                if(age > 6)
                {
                    Console.WriteLine("You are still a kiddo, kiddo");
                }
                else if (age > 0)
                {
                    Console.WriteLine("You need to grow up, stupid baby");
                }
                else
                {
                    Console.WriteLine("You have no age, zombie");
                }
            }

            if(age > 65 || age < 18)
            {
                Console.WriteLine("You have entered the danger zone");
            }
        }
    }
}
