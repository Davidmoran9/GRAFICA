using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras2
{
    public class Trapezoide : FiguraGeometrica
    {
        public double Lado1 { get; set; }
        public double Lado2 { get; set; }
        public double Lado3 { get; set; }
        public double Lado4 { get; set; }
        public double Altura { get; set; }
        public double BaseMayor { get; set; }
        public double BaseMenor { get; set; }

        public Trapezoide(double lado1, double lado2, double lado3, double lado4, double baseMayor, double baseMenor, double altura)
        {
            if (lado1 <= 0 || lado2 <= 0 || lado3 <= 0 || lado4 <= 0 || altura <= 0 || baseMayor <= 0 || baseMenor <= 0)
                throw new ArgumentException("Todos los valores deben ser positivos.");
            Lado1 = lado1;
            Lado2 = lado2;
            Lado3 = lado3;
            Lado4 = lado4;
            BaseMayor = baseMayor;
            BaseMenor = baseMenor;
            Altura = altura;
        }

        public override double CalcularArea()
        {
            return ((BaseMayor + BaseMenor) * Altura) / 2;
        }

        public override double CalcularPerimetro()
        {
            return Lado1 + Lado2 + Lado3 + Lado4;
        }
    }

}
