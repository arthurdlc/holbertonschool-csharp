using NUnit.Framework; // Import nécessaire pour les tests
using MyMath;          // Import pour accéder à la classe Operations

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {
                /// <summary>Test when a is equal to zero and b is non equal to zero.</summary>
        [Test]
        public void TestANulletBNonNull()
        {
            // Arrange
            int a = 0;
            int b = 20;

            // Act
            int output = Operations.Add(a, b);

            // Assert
            Assert.AreEqual(20, output);
        }

    }
}
