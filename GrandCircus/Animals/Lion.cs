using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iQuest.GrandCircus.Animals
{
    class Lion : AnimalBase
    {   
        public override string MakeNoise()
        {
            return "rawr";
        }
        public Lion(string name, string specie) : base(name, specie) { }

    }
}
