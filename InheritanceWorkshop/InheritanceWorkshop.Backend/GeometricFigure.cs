using System;

namespace InheritanceWorkshop.Backend
{
    public abstract class GeometricFigure
    {
        public string Name { get; set; } = string.Empty;

        public abstract double GetArea();
        public abstract double GetPerimeter();

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}