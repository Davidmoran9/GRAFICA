using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras2
{
    public class Decagono : FiguraGeometrica
    {
        public double Lado { get; set; }

        public Decagono(double lado)
        {
            if (lado <= 0)
                throw new ArgumentException("El lado debe ser positivo.");
            Lado = lado;
        }

        public override double CalcularArea()
        {
            double apotema = Lado / (2 * Math.Tan(Math.PI / 10));
            double Area = (10 * Lado * apotema)/2;
            return Math.Round(Area, 4);

        }

        public override double CalcularPerimetro()
        {
            return 10 * Lado;
        }
    }

}
