using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NCSafari
{
    public abstract class PantheraBigCat : Mammal
    {
        public PantheraBigCat(float weightInKG) : base(weightInKG) { }
        public sealed override void MakeSound() //sealed to prevent any overriding in subclasses
        {
            Console.WriteLine(this.GetType().Name + " roars!");
        }
    }
}
