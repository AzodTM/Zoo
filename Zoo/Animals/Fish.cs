using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Animals
{
    class Fish : Animal
    {
        public Fish()
        {
            legs = 2;
            eyes = 2;
            size = 40;
            coordinate = new int[2] { 5, 4 };
            scream = false;
        }
    }
}
