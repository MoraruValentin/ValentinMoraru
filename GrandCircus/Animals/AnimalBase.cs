using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iQuest.GrandCircus.Animals
{
    public abstract class AnimalBase : IAnimal
    {
        [Required(ErrorMessage = "A specie must be specified")]
        private readonly string specie;

        public string GetSpecie()
        {
            return specie;
        }
        [Required(ErrorMessage = "Name must be specified")]
        public readonly string name;
        public string GetName()
        {
            return name;
        }

        public abstract string MakeNoise();

        protected AnimalBase(string name, string specie)
        {
            this.name = name;
            this.specie = specie;
        }
    }
}
