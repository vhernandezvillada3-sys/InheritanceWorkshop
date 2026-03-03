

namespace InheritanceWorkshop.Backend;  // ← ESTE NAMESPACE ES CRÍTICO

public abstract class GeometricFigure
{
    public string Name { get; set; } = string.Empty;
    public string Color { get; set; } = string.Empty;

    public abstract double GetArea();
    public abstract double GetPerimeter();
}