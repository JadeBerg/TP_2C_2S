using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab_1;

namespace CalcTest
{
    [TestClass]
    public class TestCalc
    {
        [TestMethod]
        public void TestSum1()
        {
            Form1 calculator = new Form1();
            calculator.Put_A(4);
            double b = 6;
            double ressult = calculator.Sum(b);
            double actual = 10;
            Assert.AreEqual(ressult, actual);
        }
        [TestMethod]
        public void TestSum2()
        {
            Form1 calculator = new Form1();
            calculator.Put_A(-20);
            double b = 18;
            double ressult = calculator.Sum(b);
            double actual = -2;
            Assert.AreEqual(ressult, actual);
        }
        [TestMethod]
        public void TestSub1()
        {
            Form1 calculator = new Form1();
            calculator.Put_A(75);
            double b = 9;
            double ressult = calculator.Sub(b);
            double actual = 66;
            Assert.AreEqual(ressult, actual);
        }
        [TestMethod]
        public void TestSub2()
        {
            Form1 calculator = new Form1();
            calculator.Put_A(-120);
            double b = -20;
            double ressult = calculator.Sub(b);
            double actual = -100;
            Assert.AreEqual(ressult, actual);
        }
        [TestMethod]
        public void TestMul1()
        {
            Form1 calculator = new Form1();
            calculator.Put_A(7);
            double b = 8;
            double ressult = calculator.Mul(b);
            double actual = 56;
            Assert.AreEqual(ressult, actual);
        }
        [TestMethod]
        public void TestMul2()
        {
            Form1 calculator = new Form1();
            calculator.Put_A(100);
            double b = 0;
            double ressult = calculator.Mul(b);
            double actual = 0;
            Assert.AreEqual(ressult, actual);
        }
        [TestMethod]
        public void TestMul3()
        {
            Form1 calculator = new Form1();
            calculator.Put_A(-60);
            double b = 6;
            double ressult = calculator.Mul(b);
            double actual = -360;
            Assert.AreEqual(ressult, actual);
        }
        [TestMethod]
        public void TestDiv1()
        {
            Form1 calculator = new Form1();
            calculator.Put_A(0);
            double b = 50;
            double ressult = calculator.Div(b);
            double actual = 0;
            Assert.AreEqual(ressult, actual);
        }
        [TestMethod]
        public void TestDiv2()
        {
            Form1 calculator = new Form1();
            calculator.Put_A(700);
            double b = 7;
            double ressult = calculator.Div(b);
            double actual = 100;
            Assert.AreEqual(ressult, actual);
        }
        [TestMethod]
        public void TestDiv3()
        {
            Form1 calculator = new Form1();
            calculator.Put_A(666);
            double b = 0;
            double ressult = calculator.Div(b);
            double actual = 0;
            Assert.AreEqual(ressult, actual);
        }
        [TestMethod]
        public void TestCos1()
        {
            Form1 calculator = new Form1();
            calculator.Put_A(100);
            double ressult = calculator.cos();
            double actual = Math.Cos(100);
            Assert.AreEqual(ressult, actual);
        }
        [TestMethod]
        public void TestCos2()
        {
            Form1 calculator = new Form1();
            calculator.Put_A(0);
            double ressult = calculator.cos();
            double actual = Math.Cos(0);
            Assert.AreEqual(ressult, actual);
        }
        [TestMethod]
        public void TestCos3()
        {
            Form1 calculator = new Form1();
            calculator.Put_A(-60);
            double ressult = calculator.cos();
            double actual = Math.Cos(-60);
            Assert.AreEqual(ressult, actual);
        }
        [TestMethod]
        public void TestSqrt1()
        {
            Form1 calculator = new Form1();
            calculator.Put_A(256);
            double ressult = calculator.Sqrt();
            double actual = Math.Sqrt(256);
            Assert.AreEqual(ressult, actual);
        }
        [TestMethod]
        public void TestSqrt2()
        {
            Form1 calculator = new Form1();
            calculator.Put_A(-144);
            double ressult = calculator.Sqrt();
            double actual = Math.Sqrt(-144);
            Assert.AreEqual(ressult, actual);
        }
        [TestMethod]
        public void TestSqrt3()
        {
            Form1 calculator = new Form1();
            calculator.Put_A(0);
            double ressult = calculator.Sqrt();
            double actual = Math.Sqrt(0);
            Assert.AreEqual(ressult, actual);
        }
    }
}
