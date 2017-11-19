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
            var splitPosition = currentPosition - 1;
            if (numbers[currentPosition] > numbers[splitPosition])
            {
                var partialNumbers = GetParialNumbersFrom(currentPosition, numbers).OrderBy(num => num).ToList();
                partialNumbers.CopyTo(numbers, currentPosition);
                Swap(numbers, splitPosition, currentPosition + partialNumbers.FindIndex(x => x > numbers[splitPosition]));
                break;
            }
        }

        return Convert.ToInt64(string.Concat(numbers.ToArray()));
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
