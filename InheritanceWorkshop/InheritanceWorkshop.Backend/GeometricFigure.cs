using System;

namespace GeometricFigures.Backend
{
    public abstract class GeometricFigure
    {
        // Properties - Sin fields (propiedad automática)
        public string Name { get; set; } = string.Empty;

        // Methods
        public abstract double GetArea();
        public abstract double GetPerimeter();

        public override string ToString()
        {
            return $"{Name} => Area: {GetArea():F5}, Perimeter: {GetPerimeter():F5}";
        }
    }
}