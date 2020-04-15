using System;
using Shouldly;
using Xunit;

namespace ProjectEuler.Tests
{
    public class IntExtensions
    {
        [Fact]
        public void IsP()
        {

            11.IsPalindrome().ShouldBeTrue();
            1.IsPalindrome().ShouldBeTrue();
            202.IsPalindrome().ShouldBeTrue();
            222.IsPalindrome().ShouldBeTrue();
            2002.IsPalindrome().ShouldBeTrue();
            27272.IsPalindrome().ShouldBeTrue();

            12.IsPalindrome().ShouldBeFalse();
            121211.IsPalindrome().ShouldBeFalse();
            100.IsPalindrome().ShouldBeFalse();
            1000.IsPalindrome().ShouldBeFalse();
            1002.IsPalindrome().ShouldBeFalse();
        }
    }
}