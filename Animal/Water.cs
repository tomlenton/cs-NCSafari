using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCSafari
{
    internal class Water : SafariEnvironment<ISwim>
    {
        public override void CheckAnimalsInEnvironment()
        {
            foreach (ISwim animal in animalsInEnvironment)
            {
                animal.Swim();
            }
        }
    }
}
