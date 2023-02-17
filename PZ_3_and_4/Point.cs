using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_3_and_4
{
    public class Point
    {
        public Point(double coordX, double coordY)
        {
            this.coordX = coordX;
            this.coordY = coordY;
        }

        protected double coordX;
        protected double coordY;

        public double CoordX { get { return coordX; } set { coordX = value; } }
        public double CoordY { get { return coordY; } set { coordY = value; } }

        public void SetPoint(double coordX, double coordY)
        {
            this.coordX = coordX;
            this.coordY = coordY;
        }

        public override string ToString() => GetCoord();
        public string GetCoord() => $"({coordX}, {coordY})";
    }
}
