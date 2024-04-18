using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionTask.Models
{
    public class Cow:Animal
    {
        public Cow(string breed)
        {
            Breed = breed;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Moo!");
        }

        public override void EatFood(Food food)
        {
            if (food is Grass)
            {
                Console.WriteLine("Ugurla qidalandi.");
            }
            else
            {
                Console.WriteLine("Yanlish qida");
            }
        }

        public void ProduceMilk()
        {
            Console.WriteLine("Milk produced.");
        }

    }
}
