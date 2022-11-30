using PalindromeExercise;
using System;
using System.Runtime.CompilerServices;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {

        [Theory]
        [InlineData("recal", true )]
        [InlineData("hello",false )]
        
        public void Test1(string word, bool expected)
        {
            // Arrage
            var test = new WorldSmith();
            // act
            var actual = test.IsAPalindrome(word);
            // assert
            Assert.Equal(expected, actual);
        }
    }
}
