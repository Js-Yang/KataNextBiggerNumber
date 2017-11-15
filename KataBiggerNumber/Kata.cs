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

            var smallestNumber = string.Concat(input.ToString().OrderBy(charactor => charactor));

            var biggestNumber = smallestNumber[0];

            return Convert.ToInt64(string.Concat(smallestNumber.Substring(1, smallestNumber.Length - 1), biggestNumber));
        }

        private static bool NoMoreBiggerNumber(string input)
        {
            return input.Distinct().Count() == 1 || string.Concat(input.OrderByDescending(charactor => charactor)) == input;
        }
    }
}
