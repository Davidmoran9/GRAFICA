using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras2
{
    public class Rombo : FiguraGeometrica
    {
        public double DiagonalMayor { get; set; }
        public double DiagonalMenor { get; set; }

        public Rombo(double diagonalMayor, double diagonalMenor)
        {
            if (diagonalMayor <= 0 || diagonalMenor <= 0)
                throw new ArgumentException("Las diagonales deben ser positivas.");
            DiagonalMayor = diagonalMayor;
            DiagonalMenor = diagonalMenor;
        }

        public override double CalcularArea()
        {
            return (DiagonalMayor * DiagonalMenor) / 2;
        }

        public override double CalcularPerimetro()
        {
            double lado = Math.Sqrt(Math.Pow(DiagonalMayor / 2, 2) + Math.Pow(DiagonalMenor / 2, 2));
            return 4 * lado;
        }
    }

}
