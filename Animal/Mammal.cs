using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCSafari
{
    public abstract class Mammal : Animals
    {
        public Mammal(float weightInKG) : base(weightInKG) { }
    }
}
