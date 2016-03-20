using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public abstract class Comparer : IComparer<int[]>
    {
        public int Compare(int[] x, int[] y)
        {
            if (x == null && y == null) return 0;
            if (x == null && y != null) return -1;
            if (x != null && y == null) return 1;

            int xValue = ArrayToValue(x), yValue = ArrayToValue(y);
            if (xValue > yValue) return 1;
            else if (xValue < yValue) return -1;
            else return 0;
        }

        public abstract int ArrayToValue(int[] array);
    }
}
