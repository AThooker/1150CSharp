using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_InheritanceClasses.Animals
{
    public class Sloth : Animals
    {
        public bool isSlow
        {
            get { return true; }
        }
        public override void Move()
        {
            Console.WriteLine("The Sloth moves slowly");
        }
    }

    public class Megatherium : Sloth
    {
        public override void Move()
        {
            Console.WriteLine("Megatherium uses Move! It is not super effective....");
        }
    }
}
