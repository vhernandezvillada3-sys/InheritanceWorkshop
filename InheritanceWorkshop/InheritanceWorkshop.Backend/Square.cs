using System;

namespace GeometricFigures.Backend
{
    public class Square : GeometricFigure
    {
        protected double _a;

        public double A
        {
            get => _a;
            set => _a = ValidateA(value);
        }

        public Square(string name, double a)
        {
            Name = name;
            _a = ValidateA(a);
        }

        public override double GetArea()
        {
            return _a * _a;
        }

        public override double GetPerimeter()
        {
            return 4 * _a;
        }

        private double ValidateA(double a)
        {
            if (a <= 0)
                throw new ArgumentOutOfRangeException(nameof(a), "Side must be positive");
            return a;
        }
    }
}