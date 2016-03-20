using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class ComparerBySum : Comparer
    {
        public override int ArrayToValue(int[] array)
        {
            return array.Sum();
        }
    }
}
