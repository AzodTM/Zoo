using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Animals
{
    class Mammal : Animal   
    {
        int volumeMilkStok;
        public Mammal(int xCoordinate, int yCoortinate, int size,int volumeMilkStok)
        {   
            legs = 2;
            eyes = 2;
            size = this.size;
            coordinate = new int[2] { xCoordinate, yCoortinate };
            scream = true;
            volumeMilkStok = this.volumeMilkStok;


        }
    }
}
