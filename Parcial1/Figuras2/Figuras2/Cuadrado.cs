using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras2
{
    public class Cuadrado : FiguraGeometrica
    {
        public double Lado { get; set; }

        public Cuadrado(double lado)
        {
            if (lado <= 0)
                throw new ArgumentException("El lado debe ser positivo.");
            Lado = lado;
        }

        public override double CalcularArea()
        {
            return Math.Pow(Lado, 2);
            
        }

        public override double CalcularPerimetro()
        {
            return 4 * Lado;
        }
    }

}
