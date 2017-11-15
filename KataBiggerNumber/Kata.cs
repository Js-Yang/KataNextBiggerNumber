using System;
using System.Linq;

namespace KataBiggerNumber
{
    public class Kata
    {
        public static long NextBiggerNumber(long input)
        {
            if (NoMoreBiggerNumber(input.ToString()))
            {
                return -1;
            }

            var smallestCombination = GetSmallestCombinationOf(input);
            return Convert.ToInt64(string.Concat(smallestCombination.Substring(1, smallestCombination.Length - 1), smallestCombination.First()));
        }

        private static string GetSmallestCombinationOf(long input)
        {
            return string.Concat(input.ToString().OrderBy(charactor => charactor));
        }

        private static bool NoMoreBiggerNumber(string input)
        {
            return input.Distinct().Count() == 1 || string.Concat(input.OrderByDescending(charactor => charactor)) == input;
        }
    }
}
