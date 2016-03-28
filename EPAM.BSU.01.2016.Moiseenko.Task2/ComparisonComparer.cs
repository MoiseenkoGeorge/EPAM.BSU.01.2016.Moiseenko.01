using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class ComparisonComparer : IComparer<int[]>
    {
        private Comparison<int[]> comparison;

        public ComparisonComparer(Comparison<int[]> comparison)
        {
            this.comparison = comparison;
        }
        public int Compare(int[] x, int[] y)
        {
            return comparison(x, y);
        }
    }
}
