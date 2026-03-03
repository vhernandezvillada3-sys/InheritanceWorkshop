
namespace InheritanceWorkshop.Backend;

public class Circle : GeometricFigure
{
    // Fields
    private double _r;  // Radio

    // Properties
    public double R
    {
        get => _r;
        set => _r = ValidateR(value);
    }

    // Constructor
    public Circle(double r)
    {
        _r = ValidateR(r);
        // Name y Color se asignan desde fuera (vienen de GeometricFigure)
    }

    // Methods
    public override double GetArea()
    {
        // Área del círculo: π * r²
        return Math.PI * _r * _r;
    }

    public override double GetPerimeter()
    {
        // Perímetro (circunferencia): 2 * π * r
        return 2 * Math.PI * _r;
    }

    // Validation
    private double ValidateR(double r)
    {
        if (r <= 0)
            throw new ArgumentOutOfRangeException(nameof(r),
                "Radius must be positive");
        return r;
    }
}