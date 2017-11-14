using System;
using System.Linq;

namespace KataBiggerNumber
{
    public class Kata
    {
        public static double NextBiggerNumber(int number)
        {
            if (IsBiggestNumberSameWith(number.ToString()))
            {
                return -1;
            }

            throw new NotSupportedException();
        }

        private static bool IsBiggestNumberSameWith(string input)
        {
            return input.Distinct().Count() == 1 || string.Concat(input.OrderByDescending(charactor => charactor)) == input;
        }
    }
}
