using System;
using Xunit;

namespace PallindromeXunitTests
{
    public class PallindromeTest
    {
        [Theory]
        [InlineData("nurses run")]
        [InlineData("racecaR")]
        [InlineData("1221")]
        [InlineData("never odd, or even.")]
        [InlineData("")]
        [InlineData(",..,./,/!@#$%^&*()")]
        public void IsPallindrome(string input)
        {
            Assert.True(Pallindrome.Pallindrome.IsPalindrome(input));
        }
        [Theory]
        [InlineData("one two one")]
        [InlineData("123abccba123")]
        public void NotPallindrome(string input)
        {
            Assert.False(Pallindrome.Pallindrome.IsPalindrome(input));
        }
    }
}
