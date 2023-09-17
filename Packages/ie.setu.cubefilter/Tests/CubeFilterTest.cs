using NUnit.Framework;
using UnityEngine;

namespace Tests
{
    public class CubeFilterTest
    {
        [Test]
        public void CubeFilterSimple()
        {
            int[] input = { 1, 3, 5, 7, 9, 999 };
            int[] output = CubeFilter.cubes(input);
            int[] expected = { 1, 27, 125, 343, 729, 997002999 };

            CollectionAssert.AreEqual(expected, output);
        }

        [Test]
        public void CubeModulo3()
        {
            int[] input = { 7, 2, 8, 3, 9, 4, 10, 5, 11, 6 };
            int[] output = CubeFilter.Modulo3(input);
            int[] expected = { 1, 2, 2, 0, 0, 1, 1, 2, 2, 0 };

            CollectionAssert.AreEqual(expected, output);
        }
    }
}