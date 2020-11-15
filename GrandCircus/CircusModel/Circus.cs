using iQuest.GrandCircus.Animals;
using iQuest.GrandCircus.Presentation;
using System;

namespace iQuest.GrandCircus.CircusModel
{
    internal class Circus
    {
        public AnimalBase[] animals = new AnimalBase[3];
        public Circus(Arena arena)
        {
            animals[0] = new Lion("Simba", "Lion");
            animals[1] = new Dog("Rufus", "Dog");
            animals[2] = new Cat("Sophie", "Cat");
        }

        public void Perform(Arena arena)
        {
            arena.PresentCircus("Grand Circus");
            for(int i=0;i<3;i++)
            {
                arena.AnnounceAnimal(animals[i].GetName(), animals[i].GetSpecie());
                arena.DisplayAnimalPerformance(animals[i].MakeNoise());
            }
        }
    }
}