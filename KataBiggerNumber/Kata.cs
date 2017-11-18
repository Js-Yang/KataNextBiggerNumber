using System;
using System.Collections.Generic;
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

            return GetNextBiggerNumberBy(input);
        }

        private static bool NoMoreBiggerNumber(string input)
        {
            return input.Distinct().Count() == 1 || string.Concat(input.OrderByDescending(charactor => charactor)) == input;
        }

        private static long GetNextBiggerNumberBy(long input)
        {
            var reverseNumber = input.ToString().Select(s => int.Parse(s.ToString())).Reverse().ToList();

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

            return Convert.ToInt64(string.Concat(reverseNumber.ToArray().Reverse().ToArray()));
        }
    }
}
