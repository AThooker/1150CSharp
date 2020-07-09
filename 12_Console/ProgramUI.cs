using _12_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Console
{
    public class ProgramUI
    {
        public void Run()
        {
            Person realPerson = new Person();
            realPerson.Name = "Jeff";
            realPerson.Age = 10;
            realPerson.IsMarried = false;

            Person personTwo = new Person("Austin", 25, false);
            Console.WriteLine(personTwo.IsMarried);
            Console.ReadKey();

            Person personThree = new Person("Mike", 4, true);

            PersonRepository repo = new PersonRepository();
            repo.AddPerson(realPerson);
            repo.AddPerson(personTwo);
            repo.AddPerson(personThree);

            List<Person> returnList = repo.ReturnPerson();

            int num = returnList.Count();
            Console.WriteLine(num);


            Console.ReadLine();
        }
        
    }
}
