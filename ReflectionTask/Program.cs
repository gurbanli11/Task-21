using ReflectionTask.Models;

namespace ReflectionTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[0];
            Cow moo = new Cow("Inek");
            Lion shir = new Lion("Rex", true);
            foreach (var animal in animals)
            {
                if (animal is Lion)
                {
                    Lion lion = (Lion)animal;
                    lion.MakeSound();
                    lion.EatFood(new Meat("Et", 500));
                }
                else if (animal is Cow)
                {
                    Cow cow = (Cow)animal;
                    cow.MakeSound();
                    cow.EatFood(new Grass("Yonca", 100));
                    cow.ProduceMilk();
                }
            }
        }
    }
}