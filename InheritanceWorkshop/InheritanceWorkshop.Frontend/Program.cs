namespace InheritanceWorkshop.Frontend
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PRUEBA DE LA CLASE TRAPEZE ===\n");

            try
            {
                // Crear un trapecio
                // Parámetros: base menor, base mayor, altura, lado1, lado2
                var trapecio = new Trapeze(3, 5, 4, 4, 4.5)
                {
                    Name = "Trapecio Isósceles",
                    Color = "Marrón"
                };

                // Mostrar información
                Console.WriteLine($"Figura: {trapecio.Name}");
                Console.WriteLine($"Color: {trapecio.Color}");
                Console.WriteLine($"Base menor: 3");
                Console.WriteLine($"Base mayor: 5");
                Console.WriteLine($"Altura: 4");
                Console.WriteLine($"Lados no paralelos: 4 y 4.5");
                Console.WriteLine();

                // Calcular área y perímetro
                double area = trapecio.GetArea();
                double perimetro = trapecio.GetPerimeter();

                Console.WriteLine($"Área: {area:F2}");
                Console.WriteLine($"Perímetro: {perimetro:F2}");

                // Verificar fórmulas
                Console.WriteLine("\n--- VERIFICACIÓN ---");
                Console.WriteLine($"Área esperada: ((5 + 3) * 4) / 2 = 16");
                Console.WriteLine($"Perímetro esperado: 3 + 5 + 4 + 4.5 = 16.5");
                Console.WriteLine($"Diferencia área: {Math.Abs(area - 16):F2}");
                Console.WriteLine($"Diferencia perímetro: {Math.Abs(perimetro - 16.5):F2}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR: {ex.Message}");
            }

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}