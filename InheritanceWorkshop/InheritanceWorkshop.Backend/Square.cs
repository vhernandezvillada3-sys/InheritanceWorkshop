
namespace InheritanceWorkshop.Backend;

public class Square : GeometricFigure
{
    // Fields
    protected double _a;  // Lado 1


    // Properties
    public double A
    {
        get => _a;
        set => _a = ValidateA(value);
    }

    // Constructor
    public Square(double a)
    {
        _a = ValidateA(a);
    }

    // Methods
    public override double GetArea()
    {
        return _a * _a;
    }

    public override double GetPerimeter()
    {
        return 4 * _a;
    }

    // Validation
    private double ValidateA(double a)
    {
        if (a <= 0)
            throw new ArgumentOutOfRangeException(nameof(a), "Side must be positive");
        return a;
    }
}