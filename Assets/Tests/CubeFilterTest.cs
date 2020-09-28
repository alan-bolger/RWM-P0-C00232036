using NUnit.Framework;
using UnityEngine;

namespace Tests
{
    public class CubeFilterTest
    {
        [Test]
        public void CubeFilterSimple()
        {
            // Assert.IsTrue(false);

            int[] input = { 1, 3, 7, 7, 9, 999 }; // Error
            // int[] input = { 1, 3, 5, 7, 9, 999 }; // Correct
            int[] output = CubeFilter.cubes(input);
            int[] expected = { 1, 27, 125, 343, 729, 997002999 };

            CollectionAssert.AreEqual(expected, output);
        }
    }
}

