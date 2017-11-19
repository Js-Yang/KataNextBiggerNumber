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

        var numbers = input.ToString().ToArray();
        var splitPosition = GetSplitPositionBy(numbers);
        var firstPartialIndex = splitPosition + 1;
        var partialNumbers = GetParialNumbersFrom(firstPartialIndex, numbers).OrderBy(num => num).ToList();
        partialNumbers.CopyTo(numbers, firstPartialIndex);
        Swap(numbers, splitPosition, firstPartialIndex + partialNumbers.FindIndex(number => number > numbers[splitPosition]));

        return Convert.ToInt64(string.Concat(numbers.ToArray()));
    }

    private static bool NoMoreBiggerNumber(long input)
    {
        var numbers = input.ToString();
        return numbers.Distinct().Count() == 1 || string.Concat(numbers.OrderByDescending(charactor => charactor)) == numbers;
    }

    private static int GetSplitPositionBy(char[] numbers)
    {
        var splitPosition = 0;
        for (var index = numbers.Length - 1; index > 0; index--)
        {
            splitPosition = index - 1;
            if (numbers[index] > numbers[splitPosition])
            {
                break;
            }
        }
        return splitPosition;
    }

    private static IEnumerable<char> GetParialNumbersFrom(int index, char[] numbers)
    {
        return numbers.Skip(index).Take(numbers.Length - index);
    }

    private static void Swap(IList<char> numbers, int index, int nextIndex)
    {
        var temp = numbers[index];
        numbers[index] = numbers[nextIndex];
        numbers[nextIndex] = temp;
    }
}
