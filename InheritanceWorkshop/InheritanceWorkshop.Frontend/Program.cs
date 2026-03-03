
using InheritanceWorkshop.Backend;

namespace InheritanceWorkshop.Frontend;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== TESTING ALL GEOMETRIC FIGURES ===\n");

        try
        {
            var figures = new List<GeometricFigure>();

            // Square
            figures.Add(new Square(4) { Name = "Square" });

            // Rectangle
            figures.Add(new Rectangle(5, 3) { Name = "Rectangle" });

            // Parallelogram
            figures.Add(new Parallelogram(6, 4, 3) { Name = "Parallelogram" });

            // Rhombus
            figures.Add(new Rhombus(5, 8, 6) { Name = "Rhombus" });

            // TRIANGLE - DESCOMENTAR
            figures.Add(new Triangle(3, 4, 5, 4) { Name = "Triangle" });

            // TRAPEZE - DESCOMENTAR
            figures.Add(new Trapeze(4, 4.5, 3, 4, 5) { Name = "Trapezoid" });

            // CIRCLE - DESCOMENTAR
            figures.Add(new Circle(2.5) { Name = "Circle" });

            foreach (var figure in figures)
            {
                Console.WriteLine($"Figure: {figure.Name}");
                Console.WriteLine($"Area: {figure.GetArea():F2}");
                Console.WriteLine($"Perimeter: {figure.GetPerimeter():F2}");
                Console.WriteLine();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"ERROR: {ex.Message}");
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}