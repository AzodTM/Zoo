using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Animals
{
    class Fish : Animal
    {
        int sizeGils;
        int sizeLungs;

        
        public Fish(int xCoordinate, int yCoortinate, int size, int sizeGils, int sizeLungs)
        {
            legs = 2;
            eyes = 2;
            size = this.size;
            coordinate = new int[2] { xCoordinate, yCoortinate };
            scream = false;
            sizeGils = this.sizeGils;
            sizeLungs = this.sizeLungs;
        }
    }
}
