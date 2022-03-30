using FigureArea.Figures;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace FigureArea
{
    public abstract class Figure
    {
        /// <summary>
        /// Returns the value of the area of the figure with the specified accuracy
        /// </summary>
        /// <param name="accuracy">Number of decimal places</param>
        /// <returns>Figure area</returns>
        public abstract double Area(int accuracy);

        public static bool TryParse(string str, out Figure figure)
        {
            figure = null;

            var match = Regex.Match(str, @"^([A-za-z]+)\(([0-9., ]+)\)$");
            if (!match.Success)
            {
                return false;
            }
            try
            {
                var figureType = match.Groups[1].Value;
                var arguments = match.Groups[2].Value.Replace(" ", "").Split(",").
                    Select(arg => double.Parse(arg, CultureInfo.InvariantCulture)).ToArray();
                figure = figureType switch
                {
                    nameof(Circle) => new Circle(arguments[0]),
                    nameof(Triangle) => new Triangle(arguments[0], arguments[1], arguments[2]),
                    nameof(Ellipse) => new Ellipse(arguments[0], arguments[1]),
                    _ => throw new ArgumentException("Figure type is unknown.")
                };
            }
            catch
            {
                return false;
            }
            return true;
        }
    }

}
