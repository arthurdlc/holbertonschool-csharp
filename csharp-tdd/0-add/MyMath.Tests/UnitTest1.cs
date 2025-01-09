using NUnit.Framework; // Import nécessaire pour les tests
using MyMath;          // Import pour accéder à la classe Operations

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            // Cette méthode est exécutée avant chaque test. Tu peux l'utiliser pour configurer des pré-requis si nécessaire.
        }

        [Test]
        public void Add_TwoPositiveNumbers_ReturnsSum()
        {
            Assert.AreEqual(5, Operations.Add(2, 3), "Addition de 2 et 3 devrait donner 5.");
        }

        [Test]
        public void Add_PositiveAndNegativeNumber_ReturnsSum()
        {
            Assert.AreEqual(0, Operations.Add(5, -5), "Addition de 5 et -5 devrait donner 0.");
        }

        [Test]
        public void Add_TwoNegativeNumbers_ReturnsSum()
        {
            Assert.AreEqual(-8, Operations.Add(-3, -5), "Addition de -3 et -5 devrait donner -8.");
        }

        [Test]
        public void Add_ZeroAndNumber_ReturnsNumber()
        {
            Assert.AreEqual(7, Operations.Add(7, 0), "Addition de 7 et 0 devrait donner 7.");
            Assert.AreEqual(-4, Operations.Add(0, -4), "Addition de 0 et -4 devrait donner -4.");
        }
    }
}
