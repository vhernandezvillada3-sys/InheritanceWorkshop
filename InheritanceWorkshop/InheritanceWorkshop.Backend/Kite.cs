using System;

namespace GeometricFigures.Backend
{
    public class Kite : Rhombus
    {
        // Fields
        protected double _b;

        // Properties
        public double B
        {
            get => _b;
            set => _b = ValidateB(value);
        }

        // Constructor
        public Kite(string name, double a, double b, double d1, double d2) : base(name, a, d1, d2)
        {
            _b = ValidateB(b);
        }

        // Methods
        public override double GetArea()
        {
            return (_d1 * _d2) / 2;
        }

        public override double GetPerimeter()
        {
            return 2 * (_a + _b);
        }

        // Validation
        private double ValidateB(double b)
        {
            if (b <= 0)
                throw new ArgumentOutOfRangeException(nameof(b), "Side B must be positive");
            return b;
        }
    }
}