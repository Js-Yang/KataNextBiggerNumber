namespace KataBiggerNumber
{
    public class Kata
    {
        public static double NextBiggerNumber(int input)
        {
            if (input < 10 || (input / 10 % 10) == (input / 1 % 10))
            {
                return -1;
            }

            throw new System.NotImplementedException();
        }
    }
}
