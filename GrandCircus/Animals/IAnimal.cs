using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iQuest.GrandCircus.Animals
{
    interface IAnimal
    {
        string GetSpecie();
        string GetName();
        string MakeNoise();
    }
}
