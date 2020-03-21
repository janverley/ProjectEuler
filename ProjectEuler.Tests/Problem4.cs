using System;
using Shouldly;
using Xunit;

namespace ProjectEuler.Tests
{
    public class Problem4
    {
        [Fact]
        public void IsP()
        {

            ProjectEuler.Problem4.IsP(11).ShouldBeTrue();
            ProjectEuler.Problem4.IsP(1).ShouldBeTrue();
            ProjectEuler.Problem4.IsP(202).ShouldBeTrue();
            ProjectEuler.Problem4.IsP(222).ShouldBeTrue();
            ProjectEuler.Problem4.IsP(2002).ShouldBeTrue();
            ProjectEuler.Problem4.IsP(27272).ShouldBeTrue();

            ProjectEuler.Problem4.IsP(12).ShouldBeFalse();
            ProjectEuler.Problem4.IsP(121211).ShouldBeFalse();
            ProjectEuler.Problem4.IsP(100).ShouldBeFalse();
            ProjectEuler.Problem4.IsP(1000).ShouldBeFalse();
            ProjectEuler.Problem4.IsP(1002).ShouldBeFalse();
        }
    }
}