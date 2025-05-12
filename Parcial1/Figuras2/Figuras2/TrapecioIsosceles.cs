using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras2
{
    public class TrapecioIsosceles : FiguraGeometrica
    {
        public double BaseMayor { get; set; }
        public double BaseMenor { get; set; }
        public double Altura { get; set; }
        public double LadoIgual { get; set; }

        public TrapecioIsosceles(double baseMayor, double baseMenor, double altura, double ladoIgual)
        {
            if (baseMayor <= 0 || baseMenor <= 0 || altura <= 0 || ladoIgual <= 0)
                throw new ArgumentException("Todos los valores deben ser positivos.");
            BaseMayor = baseMayor;
            BaseMenor = baseMenor;
            Altura = altura;
            LadoIgual = ladoIgual;
        }

        public override double CalcularArea()
        {
            return ((BaseMayor + BaseMenor) * Altura) / 2;
        }

        public override double CalcularPerimetro()
        {
            return BaseMayor + BaseMenor + 2 * LadoIgual;
        }
    }

}
