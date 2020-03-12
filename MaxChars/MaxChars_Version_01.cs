using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmsDataStructures.MaxChars
{
    [TestFixture]
    class MaxChars_Version_01
    {
        public char MaxChars(string input)
        {
            IDictionary dict = new Dictionary<char, int>();
            foreach(char ch in input)
            {
                if (dict.Contains(ch))
                    dict[ch] = (int)dict[ch] + 1;
                else
                    dict.Add(ch, 1);
            }
            int max = 0;
            char res = ' ';
            foreach (DictionaryEntry kvp in dict)
            {
                if((int)kvp.Value > max)
                {
                    max = (int)kvp.Value;
                    res = (char)kvp.Key;
                }
            }

            return res;
        }

        [Test]
        [TestCase("asbasssss ds d", 's')]
        [TestCase("121211111ngb1", '1')]
        [TestCase("23123123", '2')]
        [TestCase("zsezxczdt", 'z')]
        [TestCase("x z x fe q3 g  ds d", ' ')]
        public void MaxChars_Test(string input, char output)
            => Assert.AreEqual(output, MaxChars(input));
    }
}
