using NUnit.Framework;

namespace AlgorithmsDataStructures.Palindromes
{
    [TestFixture]
    class Palindromes_Version_01
    {
        public bool Palindromes(string str)
        {
            for (int i = 0; i < str.Length; i++)
                if (str[i] != str[str.Length - 1 - i])
                    return false;

            return true;
        }

        [Test]
        [TestCase("abba", true)]
        [TestCase("abcd", false)]
        [TestCase("asdsa", true)]
        [TestCase("racecar", true)]
        public void Palindromes_Test(string input, bool result)
            => Assert.AreEqual(result, Palindromes(input));
    }
}
