using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras2
{
    public class Trapecio : FiguraGeometrica
    {
        public double BaseMayor { get; set; }
        public double BaseMenor { get; set; }
        public double Altura { get; set; }
        public double Lado1 { get; set; }
        public double Lado2 { get; set; }

        public Trapecio(double baseMayor, double baseMenor, double altura, double lado1, double lado2)
        {
            if (baseMayor <= 0 || baseMenor <= 0 || altura <= 0 || lado1 <= 0 || lado2 <= 0)
                throw new ArgumentException("Todos los valores deben ser positivos.");

            BaseMayor = baseMayor;
            BaseMenor = baseMenor;
            Altura = altura;
            Lado1 = lado1;
            Lado2 = lado2;
        }

        public override double CalcularArea()
        {
            return ((BaseMayor + BaseMenor) * Altura) / 2;
        }

        public override double CalcularPerimetro()
        {
            return BaseMayor + BaseMenor + Lado1 + Lado2;
        }
    }

}
