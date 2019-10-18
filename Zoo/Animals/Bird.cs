using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Animals
{
    class Bird : Animal
    {
        public Bird()
        {
            legs = 2;
            eyes = 2;
            size = 30;
            coordinate = new int[2] { 5, 1 };
            scream = true;
        }
    }
}
