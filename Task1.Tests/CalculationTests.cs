using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Task1.Tests
{
    [TestFixture]
    public class CalculationTests
    {
        [Test]
        [TestCase(16,2,0.00001, Result = true)]
        [TestCase(11, 2, 0.00001, Result = true)]
        [TestCase(-11, 2, 0.00001, ExpectedException = typeof(ArgumentOutOfRangeException))]
        [TestCase(111, 0, 0.00001, ExpectedException = typeof(ArgumentOutOfRangeException))]
        public bool Radix_test(double x,int n,double eps)
        {
            double radix = Task1.Calculation.Radix(x, n, eps);
            return Math.Abs((Math.Pow(x, (double)1 / n)) - radix) < eps;
        }
    }
}
