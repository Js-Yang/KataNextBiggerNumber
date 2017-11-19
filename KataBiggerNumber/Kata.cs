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
                var partialNumbers = ParialOrderBy(numbers, currentPosition);
                partialNumbers.CopyTo(numbers, currentPosition);
                Swap(numbers, priviousPosition, partialNumbers.FindIndex(x => x > numbers[priviousPosition]) + currentPosition);
                break;
            }
        }

        return Convert.ToInt64(string.Concat(numbers.ToArray()));
    }

    private static List<char> ParialOrderBy(char[] numbers, int currentPosition)
    {
        return numbers.Skip(currentPosition).Take(numbers.Length - currentPosition).OrderBy(x => x).ToList();
    }

    private static void Swap(IList<char> numbers, int i, int nextIndex)
    {
        var temp = numbers[i];
        numbers[i] = numbers[nextIndex];
        numbers[nextIndex] = temp;
    }
}
