using System;

namespace GeometricFigures.Backend
{
    public class Circle : GeometricFigure
    {
        // FIELDS
        protected double _r;

        // PROPERTIES
        public double R
        {
            get => _r;
            set => _r = value;  // ← SOLO ASIGNACIÓN, SIN VALIDACIÓN
        }

        // CONSTRUCTOR
        public Circle(string name, double r)
        {
            Name = name;
            _r = ValidateR(r);  // ← VALIDACIÓN SOLO AQUÍ
        }

        // METHODS (públicos / override)
        public override double GetArea()
        {
            return Math.PI * _r * _r;
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * _r;
        }

        // METHODS (privados / validación)
        private double ValidateR(double r)
        {
            if (r <= 0)
                throw new ArgumentOutOfRangeException(nameof(r), "Radius must be positive");
            return r;
        }
    }
}