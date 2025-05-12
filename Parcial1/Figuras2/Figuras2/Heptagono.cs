using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras2
{
    public class Heptagono : FiguraGeometrica
    {
        public double Lado { get; set; }

        public Heptagono(double lado)
        {
            if (lado <= 0)
                throw new ArgumentException("El lado debe ser positivo.");
            Lado = lado;
        }

        public override double CalcularArea()
        {
            double apotema = Lado / (2 * Math.Tan(Math.PI / 7));
            return (7 * Lado * apotema) / 2;
        }

        public override double CalcularPerimetro()
        {
            return 7 * Lado;
        }
    }

}
