using System;
using Xunit;
using FigureArea.Figures;

namespace AreaTest
{
    public class TriangleTest
    {
        [Fact]
        public void When_TriangleSideLessThenZero_Expect_ArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-2, 2, 3));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(1, -2, 3));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(2, 5, -3));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-8, -4, 3));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-4, 6, -3));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-2, -2, -3));
        }

        [Fact]
        public void When_TriangleSideEqualsZero_Expect_ArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(0,0,0));
        }

        [Fact]
        public void When_TriangleSidesIncorrect_Expect_ArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(2,10,3));
        }

        [Fact]
        public void When_TriangleSidesCorrect_Expect_CorrectArea1()
        {
            var triangle = new Triangle(5,5,8);
            Assert.Equal(12, triangle.Area(2));
        }

        [Fact]
        public void When_TriangleSidesCorrect_Expect_CorrectArea2()
        {
            var triangle = new Triangle(11.2,13.5,7.4);
            Assert.Equal(41.437, triangle.Area(3));
        }
    }
}
