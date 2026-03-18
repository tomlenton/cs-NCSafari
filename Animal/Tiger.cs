using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCSafari
{
    public class Tiger : PantheraBigCat, IMove
    {
        public Tiger(float weightInKG) : base(weightInKG) { }
        public void Move()
        {
            Console.WriteLine("Tiger is moving!");
        }
    }
}
