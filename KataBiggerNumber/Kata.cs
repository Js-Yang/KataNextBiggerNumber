using System;
using System.Linq;

namespace KataBiggerNumber
{
    public class Kata
    {
        public static double NextBiggerNumber(int inputNumber)
        {
            if (NoMoreBiggerNumber(inputNumber))
            {
                return -1;
            }

            throw new System.NotSupportedException();
        }

        private static bool NoMoreBiggerNumber(int number)
        {
            return number.ToString().Distinct().Count() == 1 || string.Concat(number.ToString().OrderByDescending(c => c)) == number.ToString();
        }
    }
}
