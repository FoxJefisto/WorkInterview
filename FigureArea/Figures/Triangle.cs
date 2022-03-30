using System;

namespace FigureArea.Figures
{
    /// <summary>
    /// This class allows you to get the area of a triangle
    /// </summary>
    public sealed class Triangle : Figure
    {
        /// <summary>
        /// This property contains the length of the first side of the triangle
        /// </summary>
        public double A { get; private set; }

        /// <summary>
        /// This property contains the length of the second side of the triangle
        /// </summary>
        public double B { get; private set; }

        /// <summary>
        /// This property contains the length of the third side of the triangle
        /// </summary>
        public double C { get; private set; }

        private bool? _isRightTriangle = null;
        
        private double? _area = null;

        /// <summary>
        /// Initializes a new instance of Triangle class with specified lengths of sides of the triangle
        /// </summary>
        /// <param name="a">Length of the first side of the triangle</param>
        /// <param name="b">Length of the second side of the triangle</param>
        /// <param name="c">Length of the third side of the triangle</param>
        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentOutOfRangeException("Sides must be positive.");
            }
            
            if ((a >= b + c) || (b >= a + c) || (c >= b + a))
            {
                throw new ArgumentOutOfRangeException("Triangle with such sides not exists.");
            }

            A = a;
            B = b;
            C = c;
        }

        /// <summary>
        /// Returns the value of the area of the triangle with the specified accuracy
        /// </summary>
        /// <param name="accuracy">Number of decimal places</param>
        /// <returns>Triangle area</returns>
        public override double Area(int accuracy)
        {
            if (!_area.HasValue)
            {
                double p = (A + B + C) / 2;
                _area = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            }
            return Math.Round(_area.Value, accuracy);   
        }

        /// <summary>
        /// Indicates whether the triangle is a right triangle
        /// </summary>
        /// <returns></returns>
        public bool IsRight()
        {
            if (!_isRightTriangle.HasValue)
            {
                _isRightTriangle = (A * A + B * B == C * C) ||
                    (A * A + C * C == B * B) ||
                    (C * C + B * B == A * A);
            }
            return _isRightTriangle.Value;
        }
    }
}
