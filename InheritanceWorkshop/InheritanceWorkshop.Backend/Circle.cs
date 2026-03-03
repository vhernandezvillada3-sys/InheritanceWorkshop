using System;

namespace GeometricFigures.Backend
{
    public class Circle : GeometricFigure
    {
        // Fields
        protected double _r;

        // Properties
        public double R
        {
            get => _r;
            set => _r = ValidateR(value);
        }

        // Constructor
        public Circle(string name, double r)
        {
            Name = name;
            _r = ValidateR(r);
        }

        // Methods
        public override double GetArea()
        {
            return Math.PI * _r * _r;
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * _r;
        }

        // Validation
        private double ValidateR(double r)
        {
            if (r <= 0)
                throw new ArgumentOutOfRangeException(nameof(r), "Radius must be positive");
            return r;
        }
    }
}