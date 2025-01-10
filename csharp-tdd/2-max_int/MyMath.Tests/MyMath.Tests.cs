using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyMath;
using System.Collections.Generic;

namespace MyMath.Tests
{
    [TestClass]
    public class OperationsTests
    {
        [TestMethod]
        public void TestMaxWithPositiveNumbers()
        {
            List<int> nums = new List<int> { 1, 2, 3, 4, 5 };
            int result = Operations.Max(nums);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void TestMaxWithNegativeNumbers()
        {
            List<int> nums = new List<int> { -1, -2, -3, -4, -5 };
            int result = Operations.Max(nums);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void TestMaxWithMixedNumbers()
        {
            List<int> nums = new List<int> { -1, 2, -3, 4, -5 };
            int result = Operations.Max(nums);
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void TestMaxWithSingleElement()
        {
            List<int> nums = new List<int> { 42 };
            int result = Operations.Max(nums);
            Assert.AreEqual(42, result);
        }

        [TestMethod]
        public void TestMaxWithEmptyList()
        {
            List<int> nums = new List<int>();
            int result = Operations.Max(nums);
            Assert.AreEqual(0, result);
        }
    }
}