using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestSimplePalindrome()
        {
            Assert.IsTrue(Str.IsPalindrome("Racecar"));
        }

        [Test]
        public void TestPhrasePalindrome()
        {
            Assert.IsTrue(Str.IsPalindrome("A man, a plan, a canal: Panama."));
        }

        [Test]
        public void TestNonPalindrome()
        {
            Assert.IsFalse(Str.IsPalindrome("Hello"));
        }

        [Test]
        public void TestEmptyString()
        {
            Assert.IsTrue(Str.IsPalindrome(""));
        }

        [Test]
        public void TestNullString()
        {
            Assert.IsFalse(Str.IsPalindrome(null));
        }
    }
}
