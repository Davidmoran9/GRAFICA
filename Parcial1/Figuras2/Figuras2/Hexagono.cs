using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras2
{
    public class Hexagono : FiguraGeometrica
    {
        public double Lado { get; set; }

        public Hexagono(double lado)
        {
            if (lado <= 0)
                throw new ArgumentException("El lado debe ser positivo.");
            Lado = lado;
        }

        public override double CalcularArea()
        {
            return ((3 * Math.Sqrt(3)) / 2) * Math.Pow(Lado, 2);
        }

        public override double CalcularPerimetro()
        {
            return 6 * Lado;
        }
    }

}
