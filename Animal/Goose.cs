using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCSafari
{
    public class Goose : Bird, IFly, ISwim
    {
        public Goose(float weightInKG) : base(weightInKG) { }
        public override void MakeSound()
        {
            Console.WriteLine("The goose honks!");
        }
        public void Swim()
        {
            Console.WriteLine(this.GetType().Name + " is swimming!");
        }
        public void Fly()
        {
            Console.WriteLine(this.GetType().Name + " is flying!");
        }
    }
}
