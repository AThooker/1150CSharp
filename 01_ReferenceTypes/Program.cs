using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {/*
            // Strings
            string thisIsDeclaration;

            string declared;
            declared = "This is initialized.";

            string declarationAndInitialization = "This is both declaring and intitializing.";

            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();

            //Concatenation
            string concatenatedFullName = firstName + " " + lastName;

            //Composite
            string compositeFullName = string.Format("{0} {1}", firstName, lastName);

            //Interpolation
            string interpolatedFullName = $"{firstName} {lastName}";

            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine(concatenatedFullName);
            Console.WriteLine(compositeFullName);
            Console.WriteLine(interpolatedFullName);
            */

            // -- Collections
            // Array
            string stringExample = "Hello World";
            string[] stringArray = { "Hello", "World!", "Why", "is it", "always", stringExample, "?" };

            string thirdItem = stringArray[2];
            Console.WriteLine(thirdItem);
            stringArray[0] = "Hey there";
            Console.WriteLine(stringArray[0]);
            
            // Lists
            List<string> listOfStrings = new List<string>();
            List<int> listOfIntegers = new List<int>();
            listOfStrings.Add("First string of our list");
            listOfIntegers.Add(4242);
            listOfIntegers.Add(12345);
            Console.WriteLine(listOfIntegers[0]);

            // Queue
            Queue<string> firstInFirstOut = new Queue<string>();
            firstInFirstOut.Enqueue("I'm first!");
            firstInFirstOut.Enqueue("I'm next");
            string firstItem = firstInFirstOut.Dequeue();
            Console.WriteLine(firstItem);



            //Dictionaries

            Dictionary<int, string> keyAndValue = new Dictionary<int, string>();
            keyAndValue.Add(7, "Agent");
            string valueSeven = keyAndValue[7];
            Console.WriteLine(valueSeven);

            // --Other Collection Examples
            SortedList<int, string> sortedKeyAndValue = new SortedList<int, string>();
            HashSet<int> uniqueList = new HashSet<int>();
            Stack<string> lastInFirstOut = new Stack<string>();

            //Classes
            Random rng = new Random();

            int randomNumber = rng.Next();
            Console.WriteLine(randomNumber);

            Console.ReadKey();

        }
    }
}
