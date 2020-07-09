using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Classes
{
    public class PersonRepository
    {
        // A new isntance - the list is empty. The list may only hold items of class Person.
        List<Person> listOfPeople = new List<Person>();

        //AddPerson method, banana is our object being added to "Person" list
        public void AddPerson(Person banana)
        {
            listOfPeople.Add(banana);
        }

        public void RemovePerson(Person orange)
        {
            listOfPeople.Remove(orange);
        }
        public List<Person> ReturnPerson()
        {
            return listOfPeople;
        }
    }
}
