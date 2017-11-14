using KataBiggerNumber;
using NUnit.Framework;

namespace KataBiggerNumberTests
{
    public class KataTest
    {
        [TestCase(9, -1, TestName = "NextBiggerNumber_When_Input_Is_9_Then_return_Minus1")]
        [TestCase(11, -1, TestName = "NextBiggerNumber_When_Input_Is_11_Then_return_Minus1")]
        [TestCase(21, -1, TestName = "NextBiggerNumber_When_Input_Is_21_Then_return_Minus1")]
        public void NextBiggerNumber_Test(int input, int expected)
        {
            var result = Kata.NextBiggerNumber(input);

            Assert.AreEqual(expected, result);
        }
    }
}
