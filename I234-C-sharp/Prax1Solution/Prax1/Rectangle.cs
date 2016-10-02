using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prax1
{
    public class Rectangle
    {
        private int _width;
        private int _height;

        public Rectangle(int width, int height)
        {
            _width = width;
            _height = height;
        }
        
        public int calcArea()
        {
            return _width * _height;
        }

        public int calcCircumference()
        {
            return 2 * (_width + _height);
        }

        public bool isEqual(Rectangle r2)
        {
            return this.calcArea() == r2.calcArea();
        }

        public bool isSquare()
        {
            return _width == _height;
        }

    }

    public class RectangleTest
    {
        public RectangleTest()
        {
            Rectangle a = new Rectangle(3, 4);
            Rectangle b = new Rectangle(2, 6);
            Rectangle c = new Rectangle(5, 5);

            Console.WriteLine("Created rectangles:\n a (3,4)\n b (2,6)\n c (5,5)");

            Console.WriteLine("area of a is " + a.calcArea());
            Console.WriteLine("circumference of b is " + b.calcCircumference());
            Console.WriteLine("are a and b equal? - " + a.isEqual(b));
            Console.WriteLine("are a and c equal? - " + a.isEqual(c));
            Console.WriteLine("is b a square? - " + b.isSquare());
            Console.WriteLine("is c a square? - " + c.isSquare());
            
        }
    }

}
