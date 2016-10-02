using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prax1
{
    class ComplexNumber
    {

        private double _realPart;
        private double _imaginaryPart;

        public double RealPart
        {
            get
            {
                return _realPart;
            }

            set
            {
                _realPart = value;
            }
        }

        public double ImaginaryPart
        {
            get
            {
                return _imaginaryPart;
            }

            set
            {
                _imaginaryPart = value;
            }
        }

        public ComplexNumber (double a, double b)
        {
            _realPart = a;
            _imaginaryPart = b;
        }

        public ComplexNumber add(ComplexNumber otherNumber)
        {
            return new ComplexNumber(this._realPart + otherNumber.RealPart, this._imaginaryPart + otherNumber.ImaginaryPart);
        }

        public ComplexNumber subtract(ComplexNumber otherNumber)
        {
            return new ComplexNumber(this._realPart - otherNumber.RealPart, this._imaginaryPart - otherNumber.ImaginaryPart);
        }


        override
        public string ToString ()
        {
            string answer = "";

            if (_realPart == 0 && _imaginaryPart == 0) return "0";

            if (_realPart != 0) answer += _realPart;
            if (_imaginaryPart != 0)
            {
                if (_imaginaryPart > 0) answer += "+";
                answer += _imaginaryPart + "i";
            }
            return answer;
        }

    }

    public class ComplexNumberTest
    {
        public ComplexNumberTest()
        {
            ComplexNumber a = new ComplexNumber(1, 2);
            ComplexNumber b = new ComplexNumber(-3, -5);

            Console.WriteLine("created new complex numbers:\n a (1, 2)\n b (-3, -5)");
            Console.WriteLine("adding a to b makes: " + a.add(b).ToString());
            Console.WriteLine("subtracting b from a makes: " + a.subtract(b).ToString());

        }
    }

}
