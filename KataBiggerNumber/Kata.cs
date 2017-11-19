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

        var candidatePosition = GetCandidatePosition(numbers);

        var splitPosition = candidatePosition + 1;
        var partialNumbers = GetParialNumbersFrom(splitPosition, numbers).OrderBy(num => num).ToList();
        partialNumbers.CopyTo(numbers, splitPosition);
        Swap(numbers, candidatePosition, splitPosition + partialNumbers.FindIndex(number => number > numbers[candidatePosition]));

        return Convert.ToInt64(string.Concat(numbers.ToArray()));
    }

    private static int GetCandidatePosition(char[] numbers)
    {
        var candidatePosition = 0;
        for (var index = numbers.Length - 1; index > 0; index--)
        {
            candidatePosition = index - 1;
            if (numbers[index] > numbers[candidatePosition])
            {
                break;
            }
        }
        return candidatePosition;
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
