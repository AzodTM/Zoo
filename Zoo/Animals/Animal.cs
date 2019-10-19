using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Animals   
{
    public abstract class Animal : IAnimalAction
    {
        public int legs;
        public int eyes;
        public int size;
        public int[] coordinate;
        public bool scream;

        public string Scream(Animal animal)
        {
            string screamText;
            if (scream)
            {
                screamText = "Какой то звук";
            }
            else
            {
                screamText = "Это животное не умеет издавать звуков";
            }
            return screamText;
        }

        /// <summary>
        /// Смена позиции животного
        /// </summary>
        /// <param name="vector">Направление (по нампаду)</param>
        /// <param name="distance">Дальность перемещения</param>
        /// <param name="animal">Животное</param>
        public void Move(int vector, int distance, Animal animal)
        {
            if (vector == 1)
            {
                coordinate[0] -= 1;
                coordinate[1] -= 1;
            }
            else if (vector == 2)
            {
                coordinate[1] -= 1;
            }
            else if (vector == 3)
            {
                coordinate[0] += 1;
                coordinate[1] -= 1;
            }
            else if (vector == 4)
            {
                coordinate[0] -= 1;
            }
            else if (vector == 6)
            {
                coordinate[0] += 1;
            }
            else if (vector == 7)
            {
                coordinate[0] -= 1;
                coordinate[1] += 1;
            }
            else if (vector == 8)
            {
                coordinate[1] += 1;
            }
            else if (vector == 7)
            {
                coordinate[0] += 1;
                coordinate[1] += 1;
            }
        }


        /// <summary>
        /// отчет о том что видит животное
        /// </summary>
        /// <param name="animal"></param>
        /// <returns></returns>
        public string LookAround(Animal animal)
        {
            string lookText = "я что то вижу";
            return lookText;

        }

    }
}
