using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iQuest.GrandCircus.Animals
{
    abstract class AnimalBase : IAnimal
    {
        [Required(ErrorMessage = "A specie must be specified")]
        private readonly string Specie;

        public string GetSpecie()
        {
            return Specie;
        }
        [Required(ErrorMessage = "Name must be specified")]
        public readonly string Name;
        public string GetName()
        {
            return Name;
        }

        public abstract string MakeNoise();

        protected AnimalBase(string name, string specie)
        {
            Name = name;
            Specie = specie;
        }
    }
}
