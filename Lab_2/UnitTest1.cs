using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab_2;

namespace Test_Lab2
{
        [TestClass]
    public class UnitTest1
    {

        public double?[] ShowRoots(double a, double b, double c)
        {
            double?[] results = new double?[2];
            double D = b * b - 4 * a * c;
            if (D > 0)
            {
                try
                {
                    double x1_res = Math.Round((-b + Math.Sqrt(D)) / (2 * a), 5);
                    double x2_res = Math.Round((-b - Math.Sqrt(D)) / (2 * a), 5);
                    results[0] = x1_res;
                    results[1] = x2_res;
                }
                catch { }
            }
            if (D == 0)
            {
                try
                {
                    double x1_res = Math.Round(-b / (2 * a), 5);
                    results[0] = x1_res;
                }
                catch { }
                results[1] = null;
            }
            if (D < 0)
            {
                results[0] = null;
                results[1] = null;
            }
            return results;
        }
        [TestMethod]
        public void Negative_D()
        {
            double?[] test_arr = { null, null };
            CollectionAssert.AreEqual(test_arr, ShowRoots(4, 5, 3));
        }
        [TestMethod]
        public void ZeroD()
        {
            double?[] test_arr = { -1, null };
            CollectionAssert.AreEqual(test_arr, ShowRoots(5, 10, 5));
        }
        [TestMethod]
        public void PositiveD()
        {
            double?[] test_arr = { 1, -7 };
            CollectionAssert.AreEqual(test_arr, ShowRoots(1, 6, -7));
        }
    }
}
