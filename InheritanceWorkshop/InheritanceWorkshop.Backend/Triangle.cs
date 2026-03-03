

namespace InheritanceWorkshop.Backend;

public class Triangle : GeometricFigure
{
    // Fields
    protected double _a;  // Side 1
    protected double _b;  // Side 2
    protected double _c;  // Base / Side 3
    protected double _h;  // Height

    // Properties
    public double A
    {
        get => _a;
        set => _a = ValidateA(value);
    }

    public double B
    {
        get => _b;
        set => _b = ValidateB(value);
    }

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
    public Triangle(double a, double b, double c, double h)
    {
        _a = ValidateA(a);
        _b = ValidateB(b);
        _c = ValidateC(c);
        _h = ValidateH(h);

        Name = string.Empty;
        Color = string.Empty;
    }

    // Virtual methods
    public override double GetArea()
    {
        // Triangle area formula: (base * height) / 2
        return (_c * _h) / 2;
    }

    public override double GetPerimeter()
    {
        // Perimeter = sum of all sides
        return _a + _b + _c;
    }

    // Validation methods
    private double ValidateA(double a)
    {
        if (a <= 0)
            throw new ArgumentOutOfRangeException(nameof(a),
                "Side A must be positive");
        return a;
    }

    private double ValidateB(double b)
    {
        if (b <= 0)
            throw new ArgumentOutOfRangeException(nameof(b),
                "Side B must be positive");
        return b;
    }

    private double ValidateC(double c)
    {
        if (c <= 0)
            throw new ArgumentOutOfRangeException(nameof(c),
                "Side C must be positive");
        return c;
    }

    private double ValidateH(double h)
    {
        if (h <= 0)
            throw new ArgumentOutOfRangeException(nameof(h),
                "Height must be positive");
        return h;
    }
}