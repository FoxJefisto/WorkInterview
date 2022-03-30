using System;
using Xunit;
using FigureArea.Figures;

namespace AreaTest
{
    public class CircleTest
    {
        [Fact]
        public void When_RadiusLessThenZero_Expect_ArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-1));
        }

        [Fact]
        public void When_RadiusEqualsZero_Expect_ArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(0));
        }

        [Fact]
        public void When_RadiusGreaterZero_Expect_CorrectArea1()
        {
            var circle = new Circle(5);
            Assert.NotNull(circle);
            Assert.Equal(5, circle.Radius);
            Assert.Equal(78.54, circle.Area(2));
        }

        [Fact]
        public void When_RadiusGreaterZero_Expect_CorrectArea2()
        {
            var circle = new Circle(10.21);
            Assert.Equal(327.4925, circle.Area(4));
        }

        [Fact]
        public void When_RadiusGreaterZero_Expect_CorrectArea3()
        {
            var circle = new Circle(17);
            Assert.Equal(907.92, circle.Area(2));
        }
    }
}
