using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iQuest.GrandCircus.Animals
{
    class Dog : AnimalBase
    {
        public override string MakeNoise()
        {
            return "bark";
        }
        public Dog(string name, string specie) : base(name, specie) { }

    }
}
