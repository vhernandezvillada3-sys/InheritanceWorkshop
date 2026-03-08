using System;

namespace GeometricFigures.Backend
{
    public class Parallelogram : Rectangle
    {
        // FIELDS
        protected double _h;

        // PROPERTIES
        public double H
        {
            get => _h;
            set => _h = value;  // ← SOLO ASIGNACIÓN, SIN VALIDACIÓN
        }

        // CONSTRUCTOR
        public Parallelogram(string name, double a, double b, double h) : base(name, a, b)
        {
            _h = ValidateH(h);  // ← VALIDACIÓN SOLO AQUÍ
        }

        // METHODS (públicos / override)
        public override double GetArea()
        {
            return _b * _h;  // ← Revisar si debe ser _a * _h
        }

        public override double GetPerimeter()
        {
            return 2 * (_a + _b);
        }

        // METHODS (privados / validación)
        private double ValidateH(double h)
        {
            if (h <= 0)
                throw new ArgumentOutOfRangeException(nameof(h), "Height must be positive");
            return h;
        }
    }
}