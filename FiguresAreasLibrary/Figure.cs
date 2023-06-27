using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresAreasLibrary
{
    abstract public class Figure
    {
        public const double CountingAccuracy = 1e-3;
        abstract public double CalculateArea();
    }
}
