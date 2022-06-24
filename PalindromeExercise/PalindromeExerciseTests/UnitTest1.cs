using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("bob",true)]
        [InlineData("hello",false)]
        [InlineData("racecar",true)]
        public void Test1(string word, bool expected)
        {
            var test = new WordSmith();
            var actual = test.IsAPalindrome(word);
            Assert.Equal(expected, actual);
        }
    }
}
