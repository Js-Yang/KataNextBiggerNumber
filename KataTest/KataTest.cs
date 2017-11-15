using KataBiggerNumber;
using NUnit.Framework;

namespace KataBiggerNumberTests
{
    public class KataTest
    {
        [TestCase(9, -1, TestName = "NextBiggerNumber When Input Is 9 Then return -1")]
        [TestCase(11, -1, TestName = "NextBiggerNumber When Input Is 11 Then return -1")]
        [TestCase(21, -1, TestName = "NextBiggerNumber When Input Is 21 Then return -1")]
        [TestCase(12, 21, TestName = "NextBiggerNumber When Input Is 12 Then return 21")]
        public void NextBiggerNumber_Test(int input, int expected)
        {
            var result = Kata.NextBiggerNumber(input);

            Assert.AreEqual(expected, result);
        }
    }
}
