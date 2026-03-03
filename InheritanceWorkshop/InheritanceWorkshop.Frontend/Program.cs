using System;
using System.Collections.Generic;
using GeometricFigures.Backend;

namespace GeometricFigures.Frontend
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== GEOMETRIC FIGURES CALCULATOR ===\n");

            try
            {
                // Crear las figuras con parámetros con nombre
                var circle = new Circle(name: nameof(Circle), r: 5);
                var square = new Square(name: nameof(Square), a: 10);
                var rhombus = new Rhombus(name: nameof(Rhombus), a: 5, d1: 7, d2: 10);
                var kite = new Kite(name: nameof(Kite), a: 7, b: 8, d1: 6, d2: 5);
                var rectangle = new Rectangle(name: nameof(Rectangle), a: 4.568, b: 67.789);
                var parallelogram = new Parallelogram(name: nameof(Parallelogram), a: 45.67, b: 78.89, h: 27.89);
                var triangle = new Triangle(name: nameof(Triangle), a: 45.56, b: 34.67, c: 23.78, h: 3.89);
                var trapeze = new Trapeze(name: nameof(Trapeze), a: 10, b: 20, c: 15, h: 30, d: 25);

                // Lista de figuras
                var figures = new List<GeometricFigure>
                {
                    circle, square, rhombus, kite, rectangle, parallelogram, triangle, trapeze
                };

                // Mostrar cada figura
                foreach (var figure in figures)
                {
                    Console.WriteLine(figure);
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
}