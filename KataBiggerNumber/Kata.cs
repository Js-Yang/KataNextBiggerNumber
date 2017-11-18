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

            var reverseNumber = input.ToString().Select(x => x - 48).ToArray().Reverse().ToList();

            for (var i = 0; i < reverseNumber.Count; i++)
            {
                var next = reverseNumber[i + 1];
                if (reverseNumber[i].CompareTo(next) == next)
                {
                    var temp = reverseNumber[i];
                    reverseNumber[i] = next;
                    reverseNumber[i + 1] = temp;
                    break;
                }
            }

            return Convert.ToInt64(string.Concat(reverseNumber.ToArray().Reverse()));
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
