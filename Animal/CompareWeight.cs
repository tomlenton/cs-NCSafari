using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCSafari
{
    public class CompareWeight : IComparer<Animals>
    {
        public bool Descending;

        public CompareWeight(bool descending)
        {
            Descending = descending;
        }

        public int Compare(Animals A, Animals B)
        {
            // Check nulls just in case
            if (A == null && B == null) return 0;
            if (A == null) return -1;
            if (B == null) return 1;

            if (A.WeightInKG > B.WeightInKG)
            {
                if (Descending)
                {
                    return -1; // if the list is descending the heaviest animal comes earlier in the list as -1 means A comes before B
                }
                else
                {
                    return 1;  // if the list as ascending the biggest animal goes last in the list as 1 means A comes after B
                }
            }
            else if (A.WeightInKG < B.WeightInKG)
            {
                if (Descending)
                {
                    return 1;  // smaller last
                }
                else
                {
                    return -1; //biggest last
                }
            }
            else
            {
                return 0; // weights are equal
            }
        }
    }
}
