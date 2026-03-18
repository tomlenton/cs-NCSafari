using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCSafari
{
    public class Penguin : Bird, IMove
    {
        public Penguin(float weightInKG) : base(weightInKG) { }
        public void Move()
        {
            Console.WriteLine("Penguin is moving!");
        }
        public override void MakeSound()
        {
            Console.WriteLine("The penguin squawks!");
        }
    }
}
