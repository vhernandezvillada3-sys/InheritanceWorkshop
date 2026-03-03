namespace InheritanceWorkshop.Backend;

public class Parallelogram : Rectangle
{
    // Fields
    private double _h;  // Altura

    // Properties
    public double H
    {
        get => _h;
        set => _h = ValidateH(value);
    }

    // Constructor
    public Parallelogram(double a, double b, double h) : base(a, b)
    {
        _h = ValidateH(h);
    }

    // Methods
    public override double GetArea()
    {
        // Área del paralelogramo = base * altura
        return _a * _h;
    }

    public override double GetPerimeter()
    {
        // Perímetro del paralelogramo = 2 * (base + lado)
        return 2 * (_a + _b);
    }

    // Validation
    private double ValidateH(double h)
    {
        if (h <= 0)
            throw new ArgumentOutOfRangeException(nameof(h), "Height must be positive");
        return h;
    }
}