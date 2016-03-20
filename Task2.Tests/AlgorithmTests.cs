using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Task2;
namespace Task2.Tests
{
    [TestFixture]
    public class AlgorithmTests
    {
        [Test]
        [TestCase(Result = 9)]
        public int BubbleSort_BySum()
        {
            ComparerBySum cbs = new ComparerBySum();
            int[][] array = new int[][]
            {
                new int[] {7,8,9},
                new int[] {4,5,6},
                new int[] {1,2,3}
            };
            array.BubbleSort(cbs);
            return array[2][2];
        }
        [Test]
        [TestCase(Result = -9)]
        public int BubbleSort_ByMaxAbs()
        {
            ComparerByMaxAbs cbms = new ComparerByMaxAbs();
            int[][] array = new int[][]
            {
                new int[] {1,2,-9},
                new int[] {4,5,6},
                new int[] {1,7,3}
            };
            array.BubbleSort(cbms);
            return array[2][2];
        }
    }
}
