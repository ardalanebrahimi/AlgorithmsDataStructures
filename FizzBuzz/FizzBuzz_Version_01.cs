using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace AlgorithmsDataStructures.FizzBuzz
{
    [TestFixture]
    class FizzBuzz_Version_01
    {
        public string FizzBuzz(int input)
        {
            string result = "";
            for (int i = 1; i <= input; i++)
                if (i % 15 == 0)
                    result = String.Concat(result, "fizzbuzz");
                else if (i % 3 == 0)
                    result = String.Concat(result, "fizz");
                else if (i % 5 == 0)
                    result = String.Concat(result, "buzz");
                else
                    result = String.Concat(result, i.ToString());
            return result;
        }

        [Test]
        [TestCase(7,"12fizz4buzzfizz7")]
        [TestCase(5,"12fizz4buzz")]
        [TestCase(3,"12fizz")]
        [TestCase(15, "12fizz4buzzfizz78fizzbuzz11fizz1314fizzbuzz")]
        public void FizzBuzz_Test(int input, string output)
            => Assert.AreEqual(output, FizzBuzz(input));
    }
}
