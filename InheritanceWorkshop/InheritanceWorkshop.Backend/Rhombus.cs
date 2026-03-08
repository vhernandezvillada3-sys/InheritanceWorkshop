using System;

namespace GeometricFigures.Backend
{
    public class Rhombus : Square
    {
        // FIELDS
        protected double _d1;
        protected double _d2;

        // PROPERTIES
        public double D1
        {
            get => _d1;
            set => _d1 = value;  // ← SOLO ASIGNACIÓN
        }

        public double D2
        {
            get => _d2;
            set => _d2 = value;  // ← SOLO ASIGNACIÓN
        }

        // CONSTRUCTOR
        public Rhombus(string name, double a, double d1, double d2) : base(name, a)
        {
            _d1 = ValidateD1(d1);
            _d2 = ValidateD2(d2);
        }

        // METHODS (públicos / override)
        public override double GetArea()
        {
            return (_d1 * _d2) / 2;
        }

        public override double GetPerimeter()
        {
            return 4 * _a;
        }

        // METHODS (privados / validación)
        private double ValidateD1(double d1)
        {
            if (d1 <= 0)
                throw new ArgumentOutOfRangeException(nameof(d1), "Diagonal 1 must be positive");
            return d1;
        }

        private double ValidateD2(double d2)
        {
            if (d2 <= 0)
                throw new ArgumentOutOfRangeException(nameof(d2), "Diagonal 2 must be positive");
            return d2;
        }
    }
}