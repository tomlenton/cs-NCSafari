using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCSafari
{
    public class Penguin : Bird, IHunt, ISwim
    {
        public Penguin(float weightInKG) : base(weightInKG) { }
        public void Hunt()
        {
            Console.WriteLine(this.GetType().Name + " is hunting in the water!");
        }
        public void Swim() {
            Console.WriteLine(this.GetType().Name + " is swimming!");
        }
        public override void MakeSound()
        {
            Console.WriteLine("The penguin squawks!");
        }
    }
}
