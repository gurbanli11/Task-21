using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionTask.Models
{
    internal class Lion:Animal
    {
        public bool IsPrideLeader { get; set; } = true;

        public Lion(string breed, bool isPrideLeader)
        {
            Breed = breed;
            IsPrideLeader = isPrideLeader;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Roar!");
        }

        public override void EatFood(Food food)
        {
            if (food is Meat)
            {
                Console.WriteLine("Successfully consumed meat.");
            }
            else
            {
                Console.WriteLine("Incorrect food type for a lion.");
            }
        }
    }
}
