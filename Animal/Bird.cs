using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCSafari
{
    public abstract class Bird : Animals
    {
        public Bird(float weightInKG) : base(weightInKG) { }
    }
}
