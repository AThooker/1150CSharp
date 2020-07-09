using _12_AnimalClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_AnimalConsole
{
    public class ProgramUI
    {
         public void Run()
        {
            Animals real = new Animals();
            real.Age = 10;
            real.Color = "blue";
            real.Eyes = 2;
            real.Nice = true;

            Animals fake = new Animals(1, "green", false, 5);

            AnimalRepository really = new AnimalRepository();
            really.AddAnimalToList(real);
            really.AddAnimalToList(fake);

            AnimalRepository work = new AnimalRepository();
            





        }
    }
}
