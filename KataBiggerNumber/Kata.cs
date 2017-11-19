using System;
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

        Console.WriteLine(input);

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

        for (var currentPosition = numbers.Length - 1; currentPosition > 0; currentPosition--)
        {
            var priviousPosition = currentPosition - 1;
            if (numbers[currentPosition] > numbers[priviousPosition])
            {
                Swap(numbers, priviousPosition, NextBiggerNumberIndexOf(currentPosition, numbers));
                break;
            }
        }

        return Convert.ToInt64(string.Concat(numbers.ToArray()));
    }

    private static int NextBiggerNumberIndexOf(int current, char[] numbers)
    {
        var partialNumbers = numbers.Skip(current).Take(numbers.Length - current).OrderBy(x => x).ToList();
        partialNumbers.CopyTo(numbers, current);
        return partialNumbers.FindIndex(x => x > numbers[current - 1]) + current;
    }

    private static void Swap(IList<char> numbers, int i, int nextIndex)
    {
        var temp = numbers[i];
        numbers[i] = numbers[nextIndex];
        numbers[nextIndex] = temp;
    }
}
