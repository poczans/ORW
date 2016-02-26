using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathsComponentNameSpace;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdd()
        {
            MathsComponent obj = new MathsComponent();
            int result = obj.Add(10, 10);
            Assert.AreEqual(20, result);
        }
        [TestMethod]
        public void TestSubstract()
        {
            MathsComponent obj = new MathsComponent();
            int result = obj.Substract(10, 10);
            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void TestMultiply()
        {
            MathsComponent obj = new MathsComponent();
            int result = obj.Multiply(10, 10);
            Assert.AreEqual(100, result);
        }
        [TestMethod]
        public void TestDivision()
        {
            MathsComponent obj = new MathsComponent();
            int result = obj.Division(10, 10);
            Assert.AreEqual(1, result);
        }
    }
}
