using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(Math.Pow(-11, (double)1 / 3));
            Console.WriteLine(Calculation.Radix(-11, 3, 0.00000000001));
            Console.WriteLine("Accuracy = {0}", Math.Abs(Math.Pow(-11, (double)1 / 3) - Calculation.Radix(-11, 3, 0.00000000001)));
            Console.ReadKey();
        }
    }
}
