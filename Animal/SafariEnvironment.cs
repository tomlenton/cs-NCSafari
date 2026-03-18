using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCSafari
{
    public abstract class SafariEnvironment<IEnvironment>
    {
        protected List<Animals> animalsInEnvironment = new List<Animals>();

        public abstract void CheckAnimalsInEnvironment();

        public void AddAnimalInEnvironment(Animals animal)
        {
            this.animalsInEnvironment.Add(animal);
        }
    }
}
