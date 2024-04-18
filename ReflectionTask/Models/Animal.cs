using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionTask.Models
{
    public abstract class Animal
    {
        public string Breed { get; set; }

        public abstract void MakeSound();

        public abstract void EatFood(Food food);
    }
}
