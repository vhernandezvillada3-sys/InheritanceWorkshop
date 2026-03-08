using System;

namespace GeometricFigures.Backend
{
    public class Triangle : Rectangle
    {
        // FIELDS
        protected double _c;
        protected double _h;

        // PROPERTIES
        public double C
        {
            get => _c;
            set => _c = value;  // ← SOLO ASIGNACIÓN
        }

        public double H
        {
            get => _h;
            set => _h = value;  // ← SOLO ASIGNACIÓN
        }

        // CONSTRUCTOR
        public Triangle(string name, double a, double b, double c, double h) : base(name, a, b)
        {
            _c = ValidateC(c);
            _h = ValidateH(h);
        }

        // METHODS (públicos / override)
        public override double GetArea()
        {
            return (_b * _h) / 2;  // ← Revisar si debe ser _c * _h
        }

        public override double GetPerimeter()
        {
            return _a + _b + _c;
        }

        // METHODS (privados / validación)
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