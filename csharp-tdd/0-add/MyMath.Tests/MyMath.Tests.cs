using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    [TestFixture]
    public class OperationsTests
    {
        [Test]
        public void Add_TwoPositiveNumbers_ReturnsCorrectSum()
        {
            Assert.AreEqual(5, Operations.Add(2, 3));
        }
        [Test]
        public void Add_PositiveAndNegativeNumber_ReturnsCorrectSum()
        {
            Assert.AreEqual(2, Operations.Add(5, -3));
        }
        [Test]
        public void Add_TwoNegativeNumbers_ReturnsCorrectSum()
        {
            Assert.AreEqual(-10, Operations.Add(-4, -6));
        }
        [Test]
        public void Add_NumberAndZero_ReturnsSameNumber()
        {
            Assert.AreEqual(7, Operations.Add(7, 0));
        }
    }
}