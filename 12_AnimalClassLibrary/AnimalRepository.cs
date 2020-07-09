using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_AnimalClassLibrary
{
    public class AnimalRepository
    {
        List<Animals> newList = new List<Animals>();

        public void AddAnimalToList(Animals a)
        {
            newList.Add(a);
        }


        public void RemoveAnimals(Animals b)
        {
            newList.Remove(b);
        }


        public void ReturnList()
        {
            newList.ForEach(Console.WriteLine);
        }

        


    }
}
