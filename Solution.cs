
using System;
using System.Collections.Generic;

public class Solution
{
    private static readonly int MODULO_VALUE = (int)Math.Pow(10, 9) + 7;

    public int CountNicePairs(int[] input)
    {
        Dictionary<int, int> differenceToFrequency = new Dictionary<int, int>();
        int totalNicePairs = 0;

        foreach (int value in input)
        {
            int difference = value - ReverseInteger(value);
            if (!differenceToFrequency.ContainsKey(difference))
            {
                differenceToFrequency.Add(difference, 0);
            }

            int frequency = differenceToFrequency[difference];
            totalNicePairs = (totalNicePairs + frequency) % MODULO_VALUE;
            ++differenceToFrequency[difference];
        }
        return totalNicePairs;
    }

    private int ReverseInteger(int value)
    {
        int reversed = 0;
        while (value > 0)
        {
            reversed = (reversed * 10) + (value % 10);
            value /= 10;
        }
        return reversed;
    }
}
