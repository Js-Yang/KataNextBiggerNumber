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
        [TestCase(513, 531, TestName = "NextBiggerNumber When Input Is 513 Then return 531")]
        [TestCase(414, 441, TestName = "NextBiggerNumber When Input Is 414 Then return 441")]
        public void NextBiggerNumber_Test(long input, long expected)
        {
            var result = Kata.NextBiggerNumber(input);

            Assert.AreEqual(expected, result);
        }
    }
}
