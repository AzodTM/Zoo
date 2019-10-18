using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Animals
{
    class Arthropod : Animal
    {
        public Arthropod()
        {
            legs = 2;
            eyes = 8;
            size = 10;
            coordinate = new int[2] { 1, 1 };
            scream = false;
            
        }
    }
}
    
    