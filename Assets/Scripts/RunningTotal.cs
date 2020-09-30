using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunningTotal
{
    public static int[] adder(int[] xs)
    {
        int[] result = new int[xs.Length];

        for (int i = 0; i < xs.Length; i++)
        {
            result[i] = xs[i];

            if (i > 0)
            {
                result[i] += result[i - 1];
            }
        }

        return result;
    }
}
