using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prax1
{
    public class Point
    {

        private int _xCoord;
        private int _yCoord;

        public int XCoord
        {
            get
            {
                return _xCoord;
            }

            set
            {
                _xCoord = value;
            }
        }

        public int YCoord
        {
            get
            {
                return _yCoord;
            }

            set
            {
                _yCoord = value;
            }
        }

        public Point(int x, int y)
        {
            XCoord = x;
            YCoord = y;
        }

        public double distanceFromZero ()
        {
            return Math.Sqrt(XCoord * XCoord + YCoord * YCoord);
        }

        public String printPointCoords()
        {
            return "x: " + XCoord + ", y: " + YCoord;
        }

        public double distanceFromPoint(Point otherPoint)
        {
            return Math.Sqrt((otherPoint.XCoord - this.XCoord) * (otherPoint.XCoord - this.XCoord) + (otherPoint.YCoord - this.YCoord) * (otherPoint.YCoord - this.YCoord));
        }

        public bool isZeroPoint()
        {
            return distanceFromPoint(new Point(0, 0)) == 0;
        }

    }

    public class PointTest
    {
        public PointTest()
        {
            Point a = new Point(3, 4);
            Point b = new Point(3, 6);
            Point c = new Point(0, 0);

            Console.WriteLine("created new points:\n a (3, 4)\n b (3, 6)\n c (0, 0)");
            Console.WriteLine("a's distance from zero is " + a.distanceFromZero());
            Console.WriteLine("a's coordinates are " + a.printPointCoords());
            Console.WriteLine("distance between a an b is " + a.distanceFromPoint(b));
            Console.WriteLine("is a the zero point? - " + a.isZeroPoint());
            Console.WriteLine("is c the zero point? - " + c.isZeroPoint());
        }
    }

}
