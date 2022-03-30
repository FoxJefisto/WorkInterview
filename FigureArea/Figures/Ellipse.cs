using System;
using System.Collections.Generic;
using System.Text;

namespace FigureArea.Figures
{
    /// <summary>
    /// This class allows you to get the area of a ellipse
    /// </summary>
    public sealed class Ellipse : Figure
    {
        /// <summary>
        /// This property contains the length of the first half-axis of the ellipse
        /// </summary>
        public double AxleA { get; private set; }
        /// <summary>
        /// This property contains the length of the second half-axis of the ellipse
        /// </summary>
        public double AxleB { get; private set; }

        private double? _area = null;

        /// <summary>
        /// Initializes a new instance of Ellipse class with specified first half-axis and second half-axis of the ellipse
        /// </summary>
        /// <param name="axleA">length of the first half-axis of the ellipse</param>
        /// <param name="axleB">length of the second half-axis of the ellipse</param>
        public Ellipse(double axleA, double axleB)
        {
            if (axleA <= 0 || axleB <= 0)
            {
                throw new ArgumentOutOfRangeException("Axles must be positive");
            }

            AxleA = axleA;
            AxleB = axleB;
        }

        /// <summary>
        /// Returns the value of the area of the ellipse with the specified accuracy
        /// </summary>
        /// <param name="accuracy">Number of decimal places</param>
        /// <returns>Ellipse area</returns>
        public override double Area(int accuracy)
        {
            if (!_area.HasValue)
            {
                _area = Math.PI * AxleA * AxleB;
            }
            return Math.Round(_area.Value, accuracy);
        }
    }
}
