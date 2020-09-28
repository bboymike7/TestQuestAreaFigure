using System;

namespace TestFigure
{
    public class AreaFigure
    {
        public double CalculateCircleArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public double CalculateTriangleArea(double aSide, double bSide, double cSide)
        {
            double i = (aSide + bSide + cSide) / 2.0;
            return Math.Round(Math.Sqrt(i * (i - aSide) * (i - bSide) * (i - cSide)), 1);
        }

        public double CalculateCubeArea(double cube)
        {
            double i = (cube * cube);
            return i;
        }
    }
}

