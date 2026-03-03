namespace InheritanceWorkshop.Backend;

public class Rhombus : Square
{
    // Fields
    protected double _d1;  // Diagonal 1
    protected double _d2;  // Diagonal 2

    // Properties
    public double D1
    {
        get => _d1;
        set => _d1 = ValidateD1(value);
    }

    public double D2
    {
        get => _d2;
        set => _d2 = ValidateD2(value);
    }

    // Constructor
    public Rhombus(double a, double d1, double d2) : base(a)
    {
        _d1 = ValidateD1(d1);
        _d2 = ValidateD2(d2);
    }

    // Methods
    public override double GetArea()
    {
        // Área del rombo = (diagonal1 * diagonal2) / 2
        return (_d1 * _d2) / 2;
    }

    public override double GetPerimeter()
    {
        // Perímetro del rombo = 4 * lado
        return 4 * _a;
    }

    // Validation
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