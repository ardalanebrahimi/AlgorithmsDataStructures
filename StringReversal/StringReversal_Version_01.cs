using NUnit.Framework;

namespace AlgorithmsDataStructures.StringReversal
{
    class StringReversal_Version_01
    {
        public string Reverse(string str)
        {
            string result = "";

            foreach (char ch in str)
                result = ch + result;

            return result;
        }
        
        [Test]
        [TestCase("abba", "abba")]
        [TestCase("abcd", "dcba")]
        [TestCase("asdsa", "asdsa")]
        [TestCase("racecar", "racecar")]
        [TestCase("ardalan", "naladra")]
        public void Reverse_Test(string input, string result)
            => Assert.AreEqual(result, Reverse(input));
    }
}
