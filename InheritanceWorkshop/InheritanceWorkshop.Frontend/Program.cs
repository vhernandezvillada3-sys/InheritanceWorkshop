
using InheritanceWorkshop.Backend;

namespace InheritanceWorkshop.Frontend;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== TESTING GEOMETRIC FIGURES ===\n");

        try
        {
            // Lista para demostrar polimorfismo
            var figures = new List<GeometricFigure>();

            // Triangle
            var triangle = new Triangle(3, 4, 5, 4)
            {
                Name = "Triangle",
                Color = "Red"
            };
            figures.Add(triangle);

            // Trapeze
            var trapeze = new Trapeze(4, 4.5, 3, 4, 5)
            {
                Name = "Trapezoid",
                Color = "Brown"
            };
            figures.Add(trapeze);

            // CIRCLE - Nueva figura
            var circle = new Circle(2.5)
            {
                Name = "Circle",
                Color = "Blue"
            };
            figures.Add(circle);

            // Mostrar todas las figuras (polimorfismo)
            foreach (var figure in figures)
            {
                Console.WriteLine($"Figure: {figure.Name} {figure.Color}");
                Console.WriteLine($"Area: {figure.GetArea():F2}");
                Console.WriteLine($"Perimeter: {figure.GetPerimeter():F2}");
                Console.WriteLine();
            }

            // Prueba específica de Circle
            Console.WriteLine("--- CIRCLE DETAILS ---");
            Console.WriteLine($"Radius: 2.5");
            Console.WriteLine($"Area (π×r²): {Math.PI * 2.5 * 2.5:F2}");
            Console.WriteLine($"Perimeter (2πr): {2 * Math.PI * 2.5:F2}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"ERROR: {ex.Message}");
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}