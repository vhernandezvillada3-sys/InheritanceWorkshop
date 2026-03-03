
using System;

namespace GeometricFigures.Backend
{
    public class Triangle : Rectangle
    {
        // Fields
        protected double _c;
        protected double _h;

        // Properties
        public double C
        {
            get => _c;
            set => _c = ValidateC(value);
        }

        public double H
        {
            get => _h;
            set => _h = ValidateH(value);
        }

        // Constructor
        public Triangle(string name, double a, double b, double c, double h) : base(name, a, b)
        {
            _c = ValidateC(c);
            _h = ValidateH(h);
        }

        // Methods
        public override double GetArea()
        {
            return (_b * _h) / 2;
        }

        public override double GetPerimeter()
        {
            return _a + _b + _c;
        }

        // Validation
        private double ValidateC(double c)
        {
            if (c <= 0)
                throw new ArgumentOutOfRangeException(nameof(c), "Side C must be positive");
            return c;
        }

        private double ValidateH(double h)
        {
            if (h <= 0)
                throw new ArgumentOutOfRangeException(nameof(h), "Height must be positive");
            return h;
        }
    }
}