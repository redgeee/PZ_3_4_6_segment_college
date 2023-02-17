using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_3_and_4
{
    public class LineSegmentOffSetPolyline : LineSegmentOffSet
    {
        public LineSegmentOffSetPolyline(Point point1, Point point2, Point point3)
            : base(point1, point2)
        {
            this.point3 = point3;
        }
        public LineSegmentOffSetPolyline(double x1, double y1, double x2, double y2,
            double x3, double y3) : base(x1, y1, x2, y2)
        {
            this.point3 = new Point(x3, y3);
        }

        protected Point point3;
        protected Point savedPoint3;

        public Point Point3
        {
            get { return this.point3; }
            set { this.point3 = value; }
        }

        protected override void SavePoints()
        {
            this.savedPoint1 = this.point1;
            this.savedPoint2 = this.point2;
            this.savedPoint3 = this.point3;
        }

        public override string ToString()
        {
            return "point1: " + this.point1.ToString() + " point2: " + this.point2.ToString() + "point3: " + this.point3.ToString();
        }

        public override void Show()
        {
            Console.WriteLine(Point1);
            Console.WriteLine(Point2);
            Console.WriteLine(Point3);
            Console.WriteLine(GetLength());
        }
    }

}
