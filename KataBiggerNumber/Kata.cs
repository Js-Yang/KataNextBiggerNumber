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

        for (var current = numbers.Length - 1; current > 0; current--)
        {
            var priviousOfCurrent = current - 1;
            if (numbers[current] > numbers[priviousOfCurrent])
            {
                Swap(numbers, priviousOfCurrent, IndexOfNextNumber(numbers, current));
                break;
            }
        }

        return Convert.ToInt64(string.Concat(numbers.ToArray()));
    }

    private static int IndexOfNextNumber(char[] numbers, int current)
    {
        var subNumbers = numbers.Skip(current).Take(numbers.Length - current).OrderBy(x => x).ToList();
        subNumbers.CopyTo(numbers, current);
        return subNumbers.FindIndex(x => x > numbers[current - 1]) + current;
    }

    private static void Swap(IList<char> numbers, int i, int nextIndex)
    {
        var temp = numbers[i];
        numbers[i] = numbers[nextIndex];
        numbers[nextIndex] = temp;
    }
}
