﻿using KataBiggerNumber;
using NUnit.Framework;

namespace KataBiggerNumberTests
{
    public class KataTest
    {
        [Test]
        public void NextBiggerNumber_When_Input_Is_9_Then_return_Minus1()
        {
            var input = 9;

            var result = Kata.NextBiggerNumber(input);

            var expected = -1;
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void NextBiggerNumber_When_Input_Is_111_Then_return_Minus1()
        {
            var input = 111;

            var result = Kata.NextBiggerNumber(input);

            var expected = -1;
            Assert.AreEqual(expected, result);
        }

    }
}
