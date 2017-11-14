using System.Linq;

namespace KataBiggerNumber
{
    public class Kata
    {
        public static double NextBiggerNumber(int input)
        {
            if (input.ToString().Distinct().Count() == 1)
            {
                return -1;
            }

            throw new System.NotImplementedException();
        }
    }
}
