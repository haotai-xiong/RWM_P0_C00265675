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

        [Test]
        public void CubeModuloFirst()
        {
            int[] input = { 4, 2, 8, 3, 9, 4, 10, 5, 11, 6 };
            int[] output = CubeFilter.ModuloFirst(input);
            int[] expected = { 0, 2, 0, 3, 1, 0, 2, 1, 3, 2 };

            CollectionAssert.AreEqual(expected, output);
        }

        [Test]
        public void CubeDecrementIfLessThanFirst()
        {
            int[] input = { 4, 2, 8, 3, 9, 4, 10, 5, 11, 6, 1 };
            int[] output = CubeFilter.DecrementIfLessThanFirst(input);
            int[] expected = { 4, 1, 8, 2, 9, 4, 10, 5, 11, 6, 0 };

            CollectionAssert.AreEqual (expected, output);
        }

        [Test]
        public void CubeRunningTotal() 
        {
            int[] input = { 4, 2, 8, 3, 9, 4, 10, 5, 11, 6 };
            int[] output = CubeFilter.RunningTotal(input);
            int[] expected = { 4, 6, 14, 17, 26, 30, 40, 45, 56, 62 };

            CollectionAssert.AreEqual (expected, output);
        }

        [Test]
        public void CubeDiff()
        {
            int[] input = { 4, 2, 8, 3, 9, 4, 10, 5, 11, 6 };
            int[] output = CubeFilter.CubeDiff(input);
            int[] expected = { 4, 2, 6, 5, 6, 5, 6, 5, 6, 5 };

            CollectionAssert.AreEqual(expected, output);
        }

        [Test]
        public void CubeFact()
        {
            int[] input = { 4, 2, 8, 3, 9, 4, 10 };
            int[] output = CubeFilter.CubeFact(input);
            int[] expected = { 24, 2, 40320, 6, 362880, 24, 3628800 };

            CollectionAssert.AreEqual(expected, output);
        }
    }
}