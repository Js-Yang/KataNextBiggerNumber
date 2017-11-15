using System;
using System.Linq;

namespace KataBiggerNumber
{
    public class Kata
    {
        public static double NextBiggerNumber(int number)
        {
            if (NoMoreBiggerNumber(number.ToString()))
            {
                return -1;
            }

            throw new NotSupportedException();
        }

        private static bool NoMoreBiggerNumber(string input)
        {
            return input.Distinct().Count() == 1 || string.Concat(input.OrderByDescending(charactor => charactor)) == input;
        }
    }
}
