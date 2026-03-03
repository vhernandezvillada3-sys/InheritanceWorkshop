using System;

namespace GeometricFigures.Backend
{
    public class Trapeze : Triangle
    {
        // Fields
        protected double _d;

        // Properties
        public double D
        {
            get => _d;
            set => _d = ValidateD(value);
        }

        // Constructor
        public Trapeze(string name, double a, double b, double c, double h, double d)
            : base(name, a, b, c, h)
        {
            _d = ValidateD(d);
        }

        // Methods
        public override double GetArea()
        {
            return ((_b + _d) * _h) / 2;
        }

        public override double GetPerimeter()
        {
            return _a + _b + _c + _d;
        }

        // Validation
        private double ValidateD(double d)
        {
            if (d <= 0)
                throw new ArgumentOutOfRangeException(nameof(d), "Side D must be positive");
            return d;
        }
    }
}