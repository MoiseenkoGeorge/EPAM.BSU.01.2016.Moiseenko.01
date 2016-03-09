using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM.BSU._01._2016.Moiseenko.Task2
{
    public static class Algorithm
    {
        public static void BubbleSort(this int[][] array, Func<int[], int> operation)
        {
            int[] temp = null;
            for (int i = array.Length - 1; i >= 0; i--)
                for (int j = 0; j < i; j++)
                    if (operation(array[j]) > operation(array[j + 1]))
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
        }
    }
}
