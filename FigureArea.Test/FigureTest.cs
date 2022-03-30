using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FigureArea;
using FigureArea.Figures;

namespace FigureArea.Test
{
    public class FigureTest
    {
        [Fact]
        public void When_TryParse_Expect_False()
        {
            Figure figure;
            Assert.False(Figure.TryParse("", out figure));
            Assert.False(Figure.TryParse("Triangle", out figure));
            Assert.False(Figure.TryParse("Triangle(2,4)", out figure));
            Assert.False(Figure.TryParse("Ellipse", out figure));
            Assert.False(Figure.TryParse("Ellipse(2)", out figure));
            Assert.False(Figure.TryParse("Circle", out figure));
            Assert.False(Figure.TryParse("Circle()", out figure));
            Assert.False(Figure.TryParse("nvsdawjdoaw(23)", out figure));
            Assert.False(Figure.TryParse("Pawdjp(5,12,64)", out figure));
        }

        [Fact]
        public void When_TryParseTriangle_Expect_True()
        {
            Figure figure;
            Assert.True(Figure.TryParse("Triangle(3,2,4)", out figure));
            Triangle triangle = figure as Triangle;
            Assert.NotNull(triangle);
            Assert.Equal(3, triangle.A);
            Assert.Equal(2, triangle.B);
            Assert.Equal(4, triangle.C);
            Assert.True(Figure.TryParse("Triangle(5.3,3.2,7.4)", out figure));
            triangle = figure as Triangle;
            Assert.NotNull(triangle);
            Assert.Equal(5.3, triangle.A);
            Assert.Equal(3.2, triangle.B);
            Assert.Equal(7.4, triangle.C);
        }

        [Fact]
        public void When_TryParseCircle_Expect_True()
        {
            Figure figure;
            Assert.True(Figure.TryParse("Circle(2)", out figure));
            Circle circle = figure as Circle;
            Assert.NotNull(circle);
            Assert.Equal(2, circle.Radius);
            Assert.True(Figure.TryParse("Circle(4.6)", out figure));
            circle = figure as Circle;
            Assert.NotNull(circle);
            Assert.Equal(4.6, circle.Radius);
        }

        [Fact]
        public void When_TryParseEllipse_Expect_True()
        {
            Figure figure;
            Assert.True(Figure.TryParse("Ellipse(4,3)", out figure));
            Ellipse ellipse = figure as Ellipse;
            Assert.NotNull(ellipse);
            Assert.Equal(4, ellipse.AxleA);
            Assert.Equal(3, ellipse.AxleB);
            Assert.True(Figure.TryParse("Ellipse(7.6,5.1)", out figure));
            ellipse = figure as Ellipse;
            Assert.NotNull(ellipse);
            Assert.Equal(7.6, ellipse.AxleA);
            Assert.Equal(5.1, ellipse.AxleB);
        }
    }
}
