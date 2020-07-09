using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Classes
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsMarried { get; set; }

        
        public Person()
        {

        }
        public Person(string name, int age, bool isMarried)
        {
            Name = name;
            Age = age;
            IsMarried = isMarried;
        }
    }
}
