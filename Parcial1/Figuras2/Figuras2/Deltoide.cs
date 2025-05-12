using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras2
{
    public class Deltoide : FiguraGeometrica
    {
        public double DiagonalMayor { get; set; }
        public double DiagonalMenor { get; set; }
        public double LadoA { get; set; }
        public double LadoB { get; set; }

        public Deltoide(double diagonalMayor, double diagonalMenor, double ladoA, double ladoB)
        {
            if (diagonalMayor <= 0 || diagonalMenor <= 0 || ladoA <= 0 || ladoB <= 0)
                throw new ArgumentException("Valores deben ser positivos.");
            DiagonalMayor = diagonalMayor;
            DiagonalMenor = diagonalMenor;
            LadoA = ladoA;
            LadoB = ladoB;
        }

        public override double CalcularArea()
        {
            return (DiagonalMayor * DiagonalMenor) / 2;

        }

        public override double CalcularPerimetro()
        {
            return 2 * (LadoA + LadoB);
        }
    }

}
