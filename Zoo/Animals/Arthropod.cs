using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Animals
{
    class Arthropod : Animal
    {
        int countSkinSHedding;

        public Arthropod(int xCoordinate,int yCoortinate,int size,int countSkinSHedding)
        {
            legs = 2;
            eyes = 8;
            size = this.size;
            coordinate = new int[2] { xCoordinate, yCoortinate };
            scream = false;
            countSkinSHedding = this.countSkinSHedding;
        }

    }
}
    
    