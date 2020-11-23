using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iQuest.GrandCircus.Animals
{
    class Cat : AnimalBase
    {
        public override string MakeNoise()
        {
            return "meow";
        }
        public Cat(string name, string specie) : base(name, specie) { }

    }
}
