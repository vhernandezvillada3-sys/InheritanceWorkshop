


namespace InheritanceWorkshop.Backend
{
    public class Triangle : Rectangle  // Hereda de Rectangle (según diagrama)
    {
        // Fields - específicos de Triangle
        protected double _c;  // Base del triángulo?
        protected double _h;  // Altura del triángulo?

        // Properties
        public double C
        {
            get => _c;
            set => _c = ValidateC(value);
        }

        public double H
        {
            get => _h;
            set => _h = ValidateH(value);
        }

        // Constructor
        public Triangle(double a, double b, double c, double h) : base(a, b)
        {
            _c = ValidateC(c);
            _h = ValidateH(h);
        }

        // Methods - Override de GetArea y GetPerimeter
        public override double GetArea()
        {
            // Área del triángulo: (base * altura) / 2
            // Asumiendo que _c es la base y _h la altura
            return (_c * _h) / 2;
        }

        public override double GetPerimeter()
        {
            // Perímetro del triángulo: suma de los 3 lados
            // _a, _b vienen de Rectangle, _c es el tercer lado
            return _a + _b + _c;
        }

        // Validation methods
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