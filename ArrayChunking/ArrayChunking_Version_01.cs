using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmsDataStructures.ArrayChunking
{
    [TestFixture]
    class ArrayChunking_Version_01
    {
        public object[] ArrayChunking(object[] input)
        {
            int chunksize = (int)input[1];

            int[] intArray = (int[])input[0];

            List<int[]> result = new List<int[]>();
            List<int> chunck = new List<int>();

            foreach (int i in (int[])input[0])
            {
                if (chunck.Count == chunksize)
                {
                    result.Add(chunck.ToArray());
                    chunck = new List<int>();
                }
                 
                chunck.Add(intArray[i - 1]);
            }

            if (chunck.Count > 0)
                result.Add(chunck.ToArray());

            return result.ToArray();
        }

        [Test]
        [TestCase(new object[] { new int[] { 1, 2, 3, 4 }, 2 },
            new object[] { new int[] { 1, 2 }, new int[] { 3, 4 } })]
        public void ArrayChunking_Test(object[] input, object[] output)
            => Assert.AreEqual(output, ArrayChunking(input));

    }
}
