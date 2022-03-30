using System;

namespace FigureArea.Figures
{
    /// <summary>
    /// This class allows you to get the area of a circle
    /// </summary>
    public sealed class Circle : Figure
    {
        /// <summary>
        /// This property contains the length of the circle radius
        /// </summary>
        public double Radius { get; private set; }

        private double? _area = null;

        /// <summary>
        /// Initializes a new instance of Circle class with specified radius
        /// </summary>
        /// <param name="radius">Length of the circle radius</param>
        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentOutOfRangeException("Radius length must be positive.");
            }
            Radius = radius;
        }

        /// <summary>
        /// Returns the value of the area of the circle with the specified accuracy
        /// </summary>
        /// <param name="accuracy">Number of decimal places</param>
        /// <returns>Circle area</returns>
        public override double Area(int accuracy)
        {
            if (!_area.HasValue) 
            {
                _area = Math.PI * Radius * Radius;
            }
            return Math.Round(_area.Value, accuracy);
        }
    }
}
