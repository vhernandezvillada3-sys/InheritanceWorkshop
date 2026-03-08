using System;

namespace GeometricFigures.Backend
{
    public class Rectangle : Square
    {
        // FIELDS
        protected double _b;

        // PROPERTIES
        public double B
        {
            get => _b;
            set => _b = value;  // ← SOLO ASIGNACIÓN, SIN VALIDACIÓN
        }

        // CONSTRUCTOR
        public Rectangle(string name, double a, double b) : base(name, a)
        {
            _b = ValidateB(b);  // ← VALIDACIÓN SOLO AQUÍ
        }

        // METHODS (públicos / override)
        public override double GetArea()
        {
            return _a * _b;
        }

        public override double GetPerimeter()
        {
            return 2 * (_a + _b);
        }

        // METHODS (privados / validación)
        private double ValidateB(double b)
        {
            if (b <= 0)
                throw new ArgumentOutOfRangeException(nameof(b), "Side B must be positive");
            return b;
        }
    }
}