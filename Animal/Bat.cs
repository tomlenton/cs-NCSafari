using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCSafari
{
    public class Bat : Mammal, IFly, IHunt
    {
        public Bat(float weightInKG) : base(weightInKG) { }
        public override void MakeSound()
        {
            Console.WriteLine("The bat !");
        }
        public void Hunt()
        {
            Console.WriteLine(this.GetType().Name + " is hunting from the air!");
        }
        public void Fly()
        {
            Console.WriteLine(this.GetType().Name + " is flying!");
        }
    }
}
