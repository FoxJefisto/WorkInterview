using System;
using Xunit;
using FigureArea.Figures;

namespace FigureArea.Test
{
    public class EllipseTest
    {
        [Fact]
        public void When_AxlesLessThenZero_Expect_ArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Ellipse(-1, 4));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Ellipse(5, -3));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Ellipse(-3, -4));
        }

        [Fact]
        public void When_AxlesEqualsZero_Expect_ArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Ellipse(0,0));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Ellipse(4,0));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Ellipse(0,3));
        }

        [Fact]
        public void When_AxlesGreaterZero_Expect_CorrectArea1()
        {
            var ellipse = new Ellipse(3,5);
            Assert.NotNull(ellipse);
            Assert.Equal(3, ellipse.AxleA);
            Assert.Equal(5, ellipse.AxleB);
            Assert.Equal(47.12, ellipse.Area(2));
        }

        [Fact]
        public void When_AxlesGreaterZero_Expect_CorrectArea2()
        {
            var ellipse = new Ellipse(7, 10);
            Assert.NotNull(ellipse);
            Assert.Equal(7, ellipse.AxleA);
            Assert.Equal(10, ellipse.AxleB);
            Assert.Equal(219.91, ellipse.Area(2));
        }

        [Fact]
        public void When_AxlesGreaterZero_Expect_CorrectArea3()
        {
            var ellipse = new Ellipse(4, 8);
            Assert.NotNull(ellipse);
            Assert.Equal(4, ellipse.AxleA);
            Assert.Equal(8, ellipse.AxleB);
            Assert.Equal(100.531, ellipse.Area(3));
        }
    }
}
