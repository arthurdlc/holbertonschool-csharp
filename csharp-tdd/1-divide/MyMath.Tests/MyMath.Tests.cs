using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    [TestFixture]
    public class MatrixTests
    {
        [Test]
        public void Divide_ValidMatrix_ReturnsDividedMatrix()
        {
            int[,] matrix = { { 4, 8 }, { 16, 20 } };
            int[,] expected = { { 2, 4 }, { 8, 10 } };
            Assert.AreEqual(expected, Matrix.Divide(matrix, 2));
        }

        [Test]
        public void Divide_DivisorIsZero_ReturnsNull()
        {
            int[,] matrix = { { 4, 8 }, { 16, 20 } };
            Assert.IsNull(Matrix.Divide(matrix, 0));
        }

        [Test]
        public void Divide_MatrixIsNull_ReturnsNull()
        {
            Assert.IsNull(Matrix.Divide(null, 2));
        }

        [Test]
        public void Divide_EmptyMatrix_ReturnsEmptyMatrix()
        {
            int[,] matrix = new int[0, 0];
            int[,] expected = new int[0, 0];
            Assert.AreEqual(expected, Matrix.Divide(matrix, 1));
        }

        [Test]
        public void Divide_NegativeDivisor_ReturnsDividedMatrix()
        {
            int[,] matrix = { { 6, -12 }, { -18, 24 } };
            int[,] expected = { { -2, 4 }, { 6, -8 } };
            Assert.AreEqual(expected, Matrix.Divide(matrix, -3));
        }
    }
}
