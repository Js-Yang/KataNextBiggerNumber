﻿using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static long NextBiggerNumber(long input)
    {
        if (NoMoreBiggerNumber(input))
        {
            return -1;
        }

        return GetNextBiggerNumberBy(input);
    }

    private static bool NoMoreBiggerNumber(long input)
    {
        var numbers = input.ToString();
        return numbers.Distinct().Count() == 1 || string.Concat(numbers.OrderByDescending(charactor => charactor)) == numbers;
    }

    private static long GetNextBiggerNumberBy(long input)
    {
        var numbers = input.ToString().ToArray();

        for (var index = numbers.Length - 1; index > 0; index--)
        {
            var nextIndex = index - 1;
            if (numbers[index] > numbers[nextIndex])
            {
                Swap(numbers, index, nextIndex);
                break;
            }
        }

        return Convert.ToInt64(string.Concat(numbers.ToArray()));
    }

    private static void Swap(IList<char> numbers, int i, int nextIndex)
    {
        var temp = numbers[i];
        numbers[i] = numbers[nextIndex];
        numbers[nextIndex] = temp;
    }
}
