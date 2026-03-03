namespace InheritanceWorkshop.Backend;

public class Trapeze : Triangle  // Hereda de Triangle
{
    // FIELDS - Solo lo específico de Trapeze
    private double _d;  // Base mayor o lado adicional del trapecio

    // PROPERTIES
    public double D
    {
        get => _d;
        set => _d = ValidateD(value);
    }

    // CONSTRUCTOR
    public Trapeze(double a, double b, double c, double h, double d)
        : base(a, b, c, h)  // Llama al constructor de Triangle
    {
        D = d;  // Valida y asigna D
    }

    // METHODS
    public override double GetArea()
    {
        // Área del trapecio: ((Base mayor + Base menor) * Altura) / 2
        // Asumiendo que:
        // - Triangle tiene _c como base menor
        // - _d es la base mayor
        // - Triangle tiene _h como altura
        return ((_d + _c) * _h) / 2;
    }

    public override double GetPerimeter()
    {
        // Perímetro del trapecio: suma de los 4 lados
        // Asumiendo que Triangle tiene:
        // - _a, _b, _c como tres lados
        // - _d es el cuarto lado
        return _a + _b + _c + _d;
    }

    // VALIDATION METHODS
    private double ValidateD(double d)
    {
        if (d <= 0)
            throw new ArgumentOutOfRangeException(nameof(d),
                "D must be greater than zero");
        return d;
    }
}