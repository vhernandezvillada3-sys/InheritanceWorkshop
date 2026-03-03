using System;

namespace GeometricFigures.Backend
{
    public class Parallelogram : Rectangle
    {
        // Fields
        protected double _h;

        // Properties
        public double H
        {
            get => _h;
            set => _h = ValidateH(value);
        }

        // Constructor
        public Parallelogram(string name, double a, double b, double h) : base(name, a, b)
        {
            _h = ValidateH(h);
        }

        // Methods
        public override double GetArea()
        {
            return _b * _h;
        }

        public override double GetPerimeter()
        {
            return 2 * (_a + _b);
        }

        // Validation
        private double ValidateH(double h)
        {
            if (h <= 0)
                throw new ArgumentOutOfRangeException(nameof(h), "Height must be positive");
            return h;
        }
    }
}