using NUnit.Framework;
using UnityEngine;

namespace Tests
{
    public class RunningTotalTest
    {
        // Name: RunningTotal
        // Replace each number by the sum of itself and all the previous numbers.
        // Sample Input: 4 2 8 3 9 4 10 5 11 6
        // Sample Output: 4 6 14 17 26 30 40 45 56 62

        [Test]
        public void RunningTotal_IO()
        {
            int[] input = { 4, 2, 8, 3, 9, 4, 10, 5, 11, 6, -4, -1, 2, -6, -10, 7, -12, 5, -21 };
            int[] output = RunningTotal.adder(input);
            int[] expected = { 4, 6, 14, 17, 26, 30, 40, 45, 56, 62, 58, 57, 59, 53, 43, 50, 38, 43, 22 };

            CollectionAssert.AreEqual(expected, output);
        }
    }
}

