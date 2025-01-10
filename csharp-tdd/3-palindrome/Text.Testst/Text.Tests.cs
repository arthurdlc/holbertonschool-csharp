using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    ///<summary>Classe contenant les tests pour la méthode IsPalindrome</summary>
    public class Tests
    {
        [Test]
        ///<summary>
        /// Teste si une chaîne qui est un palindrome simple ("yay") renvoie true.
        /// </summary>
        public void Test1()
        {
            string word = "yay"; // Chaîne d'entrée
            bool output = Str.IsPalindrome(word); // Appelle la méthode à tester
            Assert.AreEqual(true, output); // Vérifie que le résultat attendu est true
        }

        [Test]
        ///<summary>
        /// Teste si une chaîne qui n'est pas un palindrome ("yays") renvoie false.
        /// </summary>
        public void TestNotPal()
        {
            string word = "yays"; // Chaîne d'entrée
            bool output = Str.IsPalindrome(word); // Appelle la méthode à tester
            Assert.AreEqual(false, output); // Vérifie que le résultat attendu est false
        }

        [Test]
        ///<summary>
        /// Teste si une chaîne vide ("") est considérée comme un palindrome (devrait renvoyer true).
        /// </summary>
        public void TestEmpty()
        {
            string word = ""; // Chaîne vide en entrée
            bool output = Str.IsPalindrome(word); // Appelle la méthode à tester
            Assert.AreEqual(true, output); // Vérifie que le résultat attendu est true
        }

        [Test]
        ///<summary>
        /// Teste si une chaîne avec une seule lettre ("y") est un palindrome (devrait renvoyer true).
        /// </summary>
        public void Test1Letter()
        {
            string word = "y"; // Chaîne d'entrée avec une seule lettre
            bool output = Str.IsPalindrome(word); // Appelle la méthode à tester
            Assert.AreEqual(true, output); // Vérifie que le résultat attendu est true
        }

        [Test]
        ///<summary>
        /// Teste une phrase contenant des majuscules, des espaces, et de la ponctuation 
        /// ("A man, a plan, a canal: Panama.") pour vérifier que la méthode est insensible
        /// aux majuscules et à la ponctuation.
        /// </summary>
        public void TestPuncLowercaseSpaces()
        {
            string word = "A man, a plan, a canal: Panama."; // Phrase complexe
            bool output = Str.IsPalindrome(word); // Appelle la méthode à tester
            Assert.AreEqual(true, output); // Vérifie que le résultat attendu est true
        }
    }
}
