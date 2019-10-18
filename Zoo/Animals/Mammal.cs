using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Animals
{
    class Mammal : Animal   
    {
        public Mammal()
        {   
                legs = 2;
                eyes = 2;
                size = 200;
                coordinate = new int[2] { 3, 4 };
                scream = true;
            
        }
    }
}
