using System;

namespace GeometricFigures.Backend
{
    public abstract class GeometricFigure
    {
        // Propiedad automática (sin field adicional)
        public string Name { get; set; } = string.Empty;

        // Métodos abstractos que deben implementar las clases hijas
        public abstract double GetArea();
        public abstract double GetPerimeter();

        // ToString con el formato exacto que definimos:
        // - Nombre alineado a la izquierda (15 caracteres)
        // - "=> Area.....: " texto fijo
        // - Área alineada a la derecha (12 caracteres, 5 decimales)
        // - ", Perimeter: " texto fijo
        // - Perímetro alineado a la derecha (12 caracteres, 5 decimales)
        public override string ToString()
        {
            string nombreFormateado = Name.PadRight(15);                     // Columna nombre: 15 caracteres, alineación izquierda
            string areaFormateada = GetArea().ToString("F5").PadLeft(12);    // Área: 12 caracteres, alineación derecha
            string perimetroFormateado = GetPerimeter().ToString("F5").PadLeft(12); // Perímetro: 12 caracteres, alineación derecha

            return $"{nombreFormateado}=> Area.....: {areaFormateada}, Perimeter: {perimetroFormateado}";
        }
    }
}