using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresAreasLibrary
{
    public class Circle : Figure
    {
        public string ArgumentOutOfRangeErrorMessage
        {
            get { return "Radius was too small to continue calculations."; }
        }

        public Circle(double radius)
        {
            if (radius < CountingAccuracy)
                throw new ArgumentOutOfRangeException(ArgumentOutOfRangeErrorMessage);
            Radius = radius;
        }
        public double Radius { get; }
        public override double CalculateArea()
        {
            double s = Math.PI * Math.Pow(Radius, 2);
            return Math.Truncate(s / CountingAccuracy) * CountingAccuracy;
        }
    }
}
