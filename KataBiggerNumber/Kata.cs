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
        
        for (var index = numbers.Length - 1; index > 0; index--)
        {
            var nextIndex = index - 1;
            if (numbers[index] > numbers[nextIndex])
            {
                var subNumbers = numbers.Skip(index).Take(numbers.Length - index).OrderBy(x => x).ToArray();
                Array.Copy(subNumbers, 0, numbers, index, subNumbers.Length);
                for (int i = 0; i < subNumbers.Length; i++)
                {
                    if (numbers[nextIndex] < subNumbers[i])
                    {
                        Swap(numbers, nextIndex, i + index);
                        break;
                    }
                }
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
