using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM.BSU._01._2016.Moiseenko.Task1
{
    internal class Calculation
    {
        /// <param name="x">A double-precision floating-point number which radix will find </param>
        /// <param name="n">A integer number that specifies a power</param>
        /// <param name="eps">A double-precision floating-point number that specifies accuracy of calculations</param>
        /// <returns>Returns a specified number that specifies radix of x</returns>
        public static double Radix(double x, int n, double eps)
        {
            double radix = 1, nextRadix;
            while (true)
            {
                nextRadix = ((double)1 / n) * ((n - 1) * radix + x / Math.Pow(radix, n - 1));
                if (Math.Abs(Math.Abs(Math.Pow(nextRadix, n)) - Math.Abs(x)) < eps) return nextRadix;
                radix = nextRadix;
            }
        }
    }
}
