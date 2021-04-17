using NUnit.Framework;
using Lab_3;
using static Lab_3.Form1;

namespace Test3
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestOp1()
        {
            CustomArray MyArray = new CustomArray();
            int[] array = { -13, -1692, 110, 1283, -1127, 3420, -951};
            int[] test = {3420, 1283, 110, -13, -951, -1127, -1692};
            CollectionAssert.AreEqual(test, MyArray.ReverseArray(array));
        }
        [Test]
        public void TestOp2()
        {
            CustomArray MyArray = new CustomArray();
            int[] array = { 1695, -2571, -436, -796, 1001, 2962, -392, 1634, 1454, 1939};
            int k = 3;
            int min = -5000;
            int max = 5000;
            int[] test = { 1,6,3};
            CollectionAssert.AreEqual(test, MyArray.Sub_intervals(array, k, min, max));
        }
        [Test]
        public void TestOp3()
        {
            CustomArray MyArray = new CustomArray();
            int[] array = { 2597, 3282, -2383, -1602, 4221, -2327, -4084, -4794, 3523, -2933};
            int[] test = { 4221, 1};
            CollectionAssert.AreEqual(test, MyArray.Sum_3(array));
        }
        [Test]
        public void TestOp4()
        {
            CustomArray MyArray = new CustomArray();
            int[] array = {4195, 20, -4514, 1717, 4951, -1964, 4072, 4115, -204, 28};
            int test = 1;
            Assert.AreEqual(test, MyArray.CountPrimes(array));
        }
    }
}