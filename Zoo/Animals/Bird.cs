using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Animals
{
    class Bird : Animal
    {
        int quantityWings;
        int rangeOfFlyght;
        public Bird(int xCoordinate, int yCoortinate, int size, int quantityWings,int rangeOfFlyght)
        {
            legs = 2;
            eyes = 2;
            size = this.size;
            coordinate = new int[2] { xCoordinate, yCoortinate };
            scream = true;
            quantityWings = this.quantityWings;
            rangeOfFlyght = this.rangeOfFlyght;
        }
       
    }
}
