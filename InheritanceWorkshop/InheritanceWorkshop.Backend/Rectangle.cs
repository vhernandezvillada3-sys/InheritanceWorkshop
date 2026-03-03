
namespace InheritanceWorkshop.Backend;

public class Rectangle : Square
{
    // Fields (hereda _a y _b de Square)
    protected double _b;  // Lado 2 (puede ser diferente a _a en un rectángulo)
    // Properties
    protected double B
    {
        get => _b;
        set => _b = ValidateB(value);
    }

    // Constructor
    public Rectangle(double a, double b) : base(a)
    {
        _b = ValidateB(b);
    }

    // Methods
    public override double GetArea()
    {
        return _a * _b;
    }

    public override double GetPerimeter()
    {
        return 2 * (_a + _b);
    }

    // Validation
    private double ValidateB(double b)
    {
        if (b <= 0)
            throw new ArgumentOutOfRangeException(nameof(b), "Side B must be positive");
        return b;
    }
}