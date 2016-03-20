using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class ComparerByMaxAbs : Comparer
    {
        public override int ArrayToValue(int[] array)
        {
            int max = Math.Abs(array.Max()), min = Math.Abs(array.Min());
            return max > min ? max : min; 
        }
    }
}
