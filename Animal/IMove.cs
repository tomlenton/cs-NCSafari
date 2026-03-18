using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCSafari
{
    [Obsolete("IMove has been replaced by specific interfaces instead. Please use IFly, IHunt or ISwim instead.")]
    public interface IMove
    {
        public void Move();
    }
}
