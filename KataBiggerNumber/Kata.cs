using System.Linq;

namespace KataBiggerNumber
{
    public class Kata
    {
        public static double NextBiggerNumber(int input)
        {
            if (NoMoreBiggerNumber(input))
            {
                return -1;
            }

            throw new System.NotSupportedException();
        }

        private static bool NoMoreBiggerNumber(int input)
        {
            return input.ToString().Distinct().Count() == 1;
        }
    }
}
