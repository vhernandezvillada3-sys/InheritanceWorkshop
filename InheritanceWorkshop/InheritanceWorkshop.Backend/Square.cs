using System;

namespace GeometricFigures.Backend
{
    public class Square : GeometricFigure
    {
        // 1. FIELDS (CAMPOS)
        protected double _a;

        // 2. PROPERTIES (PROPIEDADES)
        public double A
        {
            get => _a;
            set => _a = value;
        }

        // 3. CONSTRUCTOR
        public Square(string name, double a)
        {
            Name = name;
            _a = ValidateA(a);
        }

        // 4. METHODS (MÉTODOS PÚBLICOS - SOBRESCRITOS)
        public override double GetArea()
        {
            return _a * _a;
        }

        public override double GetPerimeter()
        {
            return 4 * _a;
        }

        // 5. METHODS (MÉTODOS PRIVADOS - VALIDACIÓN)
        private double ValidateA(double a)
        {
            if (a <= 0)
                throw new ArgumentOutOfRangeException(nameof(a), "Side must be positive");
            return a;
        }
    }
}