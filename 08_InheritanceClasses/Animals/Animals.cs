using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_InheritanceClasses.Animals
{
    public enum DietType { Herbivore, Omnivore, Carnivore, Insectivore}
    public class Animals
    {
        public int NumberOfLegs { get; set; }
        public bool IsMammal { get; set; }
        public bool HasFur { get; set; }
        public bool IsEndangered { get; set; }
        public DietType TypeOfDiet { get; set; }

        public virtual void Move()
        {
            Console.WriteLine($"This{GetType().Name} moves.");
        }

    }
}
