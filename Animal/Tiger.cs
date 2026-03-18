using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCSafari
{
    public class Tiger : PantheraBigCat, IHunt
    {
        public Tiger(float weightInKG) : base(weightInKG) { }
        public void Hunt()
        {
            Console.WriteLine(this.GetType().Name + " is hunting on land!");
        }
    }
}
