using System;

namespace GeometricFigures.Backend
{
    public class Trapeze : Triangle
    {
        // FIELDS
        protected double _d;

        // PROPERTIES
        public double D
        {
            get => _d;
            set => _d = value;  // ← SOLO ASIGNACIÓN, SIN VALIDACIÓN
        }

        // CONSTRUCTOR
        public Trapeze(string name, double a, double b, double c, double h, double d)
            : base(name, a, b, c, h)
        {
            _d = ValidateD(d);  // ← VALIDACIÓN SOLO AQUÍ
        }

        // METHODS (públicos / override)
        public override double GetArea()
        {
            return ((_b + _d) * _h) / 2;
        }

        public override double GetPerimeter()
        {
            return _a + _b + _c + _d;
        }

        // METHODS (privados / validación)
        private double ValidateD(double d)
        {
            if (d <= 0)
                throw new ArgumentOutOfRangeException(nameof(d), "Side D must be positive");
            return d;
        }
    }
}