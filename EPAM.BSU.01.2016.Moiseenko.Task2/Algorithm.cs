using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public static class Algorithm
    {
        private static void Swap(ref int[] left, ref int[] right)
        {
            int[] temp = left;
            left = right;
            right = temp;
        }
        public static void BubbleSortByInterfaceThrowDelegate(this int[][] array, IComparer<int[]> comparator)
        {
            array.BubbleSortDelegate(comparator.Compare);
        }

        public static void BubbleSortByDelegateThrowInterface(this int[][] array, Comparison<int[]> comparison)
        {
            array.BubbleSortInterface(new ComparisonComparer(comparison));
        }
        public static void BubbleSortInterface(this int[][] array, IComparer<int[]> comparator)
        {
            for (int i = array.Length - 1; i >= 0; i--)
                for (int j = 0; j < i; j++)
                    if (comparator.Compare(array[j], array[j + 1]) > 0)
                        Swap(ref array[j], ref array[j + 1]);
        }
        public static void BubbleSortDelegate(this int[][] array, Comparison<int[]> comparison)
        {
            for (int i = array.Length - 1; i >= 0; i--)
                for (int j = 0; j < i; j++)
                    if(comparison(array[j], array[j+1]) > 0)
                        Swap(ref array[j], ref array[j + 1]);
        }
    }
}
