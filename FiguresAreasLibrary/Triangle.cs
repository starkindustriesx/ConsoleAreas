using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresAreasLibrary
{
    public class Triangle : Figure
    {
        public double SideA
        {
            get; set;
        }

        public double SideB
        {
            get; set;
        }

        public double SideC
        {
            get; set;
        }

        public string ArgumentOutOfRangeErrorMessage
        {
            get { return "Side was too small to continue calculations."; }
        }

        public string ArgumentErrorMessage
        {
            get { return "Such triangle doesn't exist."; }
        }

        public bool IsRectangular
        {
            get { return CalculateIfRectangular(); }
        }

        public Triangle()
        {
            SideA = 0;
            SideB = 0;
            SideC = 0;
        }

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= CountingAccuracy)
                throw new ArgumentOutOfRangeException(ArgumentOutOfRangeErrorMessage);

            if (sideB <= CountingAccuracy)
                throw new ArgumentOutOfRangeException(ArgumentOutOfRangeErrorMessage);

            if (sideC <= CountingAccuracy)
                throw new ArgumentOutOfRangeException(ArgumentOutOfRangeErrorMessage);

            double maxSideLenght = Math.Max(sideA, sideB);
            maxSideLenght = Math.Max(maxSideLenght, sideC);
            if (sideA + sideB + sideC - maxSideLenght * 2 <= CountingAccuracy)
                throw new ArgumentException(ArgumentErrorMessage);

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public override double CalculateArea()
        {
            double p = (SideA + SideB + SideC) / 2;
            double s = Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
            return Math.Truncate(s / CountingAccuracy) * CountingAccuracy;
        }

        public bool CalculateIfRectangular()
        {
            if (Math.Abs(Math.Pow(SideA, 2) - Math.Pow(SideB, 2) - Math.Pow(SideC, 2)) < CountingAccuracy ||
                Math.Abs(Math.Pow(SideB, 2) - Math.Pow(SideA, 2) - Math.Pow(SideC, 2)) < CountingAccuracy ||
                Math.Abs(Math.Pow(SideC, 2) - Math.Pow(SideA, 2) - Math.Pow(SideB, 2)) < CountingAccuracy)
                return true;
            else return false;
        }
    }
}
