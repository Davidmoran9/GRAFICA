using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras2
{
    public class Eneagono : FiguraGeometrica
    {
        public double Lado { get; set; }

        public Eneagono(double lado)
        {
            if (lado <= 0)
                throw new ArgumentException("El lado debe ser positivo.");
            Lado = lado;
        }

        public override double CalcularArea()
        {
            double apotema = Lado / (2 * Math.Tan(Math.PI / 9));
            return (9 * Lado * apotema) / 2;
        }

        public override double CalcularPerimetro()
        {
            return 9 * Lado;
        }
    }

}
