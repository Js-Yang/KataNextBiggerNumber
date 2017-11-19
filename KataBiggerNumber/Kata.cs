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
        SortNumbersFrom(splitPosition, numbers);
        Swap(splitPosition, FindBiggerNumberFrom(splitPosition, numbers), numbers);

        return Convert.ToInt64(string.Concat(numbers.ToArray()));
    }

    private static void SortNumbersFrom(int index, char[] numbers)
    {
        var partialPostion = index + 1;
        GetParialNumbersFrom(partialPostion, numbers).OrderBy(num => num).ToList().CopyTo(numbers, partialPostion);
    }

    private static int FindBiggerNumberFrom(int index, char[] numbers)
    {
        var startIndex = index + 1;
        return numbers.ToList().FindIndex(startIndex, number => number > numbers[index]);
    }

    private static bool NoMoreBiggerNumber(long input)
    {
        var numbers = input.ToString();
        return numbers.Distinct().Count() == 1 || string.Concat(numbers.OrderByDescending(charactor => charactor)) == numbers;
    }

    private static IEnumerable<char> GetParialNumbersFrom(int index, char[] numbers)
    {
        return numbers.Skip(index).Take(numbers.Length - index);
    }

    private static void Swap(int index, int nextIndex, IList<char> numbers)
    {
        var temp = numbers[index];
        numbers[index] = numbers[nextIndex];
        numbers[nextIndex] = temp;
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
}
