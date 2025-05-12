using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras2
{
    public class Triangulo : FiguraGeometrica
    {
        public double Lado1 { get; set; }
        public double Lado2 { get; set; }
        public double Lado3 { get; set; }

        public Triangulo(double lado1, double lado2, double lado3)
        {
            if (lado1 <= 0 || lado2 <= 0 || lado3 <= 0)
                throw new ArgumentException("Los lados deben ser positivos.");
            if (lado1 + lado2 <= lado3 || lado1 + lado3 <= lado2 || lado2 + lado3 <= lado1)
                throw new ArgumentException("Los lados no forman un triángulo válido.");

            Lado1 = lado1;
            Lado2 = lado2;
            Lado3 = lado3;
        }

        public override double CalcularArea()
        {
            double s = (Lado1 + Lado2 + Lado3) / 2;
            return Math.Sqrt(s * (s - Lado1) * (s - Lado2) * (s - Lado3)); // Fórmula de Herón
        }

        public override double CalcularPerimetro()
        {
            return Lado1 + Lado2 + Lado3;
        }
    }

}
