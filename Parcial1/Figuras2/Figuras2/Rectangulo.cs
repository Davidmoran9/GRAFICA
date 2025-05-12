using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras2
{
    public class Rectangulo : FiguraGeometrica
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public Rectangulo(double baseR, double altura)
        {
            if (baseR <= 0 || altura <= 0)
                throw new ArgumentException("Las dimensiones deben ser positivas.");
            Base = baseR;
            Altura = altura;
        }

        public override double CalcularArea()
        {
            return Base * Altura;
        }

        public override double CalcularPerimetro()
        {
            return 2 * (Base + Altura);
        }
    }

}
