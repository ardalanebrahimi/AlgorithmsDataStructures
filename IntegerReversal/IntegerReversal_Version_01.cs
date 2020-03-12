using NUnit.Framework;
using System;

namespace AlgorithmsDataStructures.IntegerReversal
{
    [TestFixture]
    class IntegerReversal_Version_01
    {
        public int IntegerReversal(int input)
        {
            bool isPositive = (input >= 0);

            int intHolder = isPositive ? input : input * -1;

            string revStr = "";
            foreach (char ch in intHolder.ToString())
                revStr = ch + revStr;

            int revInt = Convert.ToInt32(revStr);

            return isPositive ? revInt : revInt * -1;
        }

        [Test]
        [TestCase(500, 5)]
        [TestCase(123, 321)]
        [TestCase(-500, -5)]
        [TestCase(-23, -32)]
        [TestCase(0, 0)]
        public void IntegerReversal_Test(int input, int result)
            => Assert.AreEqual(IntegerReversal(input), result);
    }
}
