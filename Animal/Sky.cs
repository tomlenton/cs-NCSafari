using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCSafari
{
    public class Sky : SafariEnvironment<IFly>
    {
        public override void CheckAnimalsInEnvironment()
        {
            foreach (IFly animal in animalsInEnvironment)
            {
                animal.Fly();
            }
        }
    }
}
