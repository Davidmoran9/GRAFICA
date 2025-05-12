using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras2
{
    public class Romboide : FiguraGeometrica
    {
        public double Base { get; set; }
        public double Altura { get; set; }
        public double Lado { get; set; }

        public Romboide(double baseR, double altura, double lado)
        {
            if (baseR <= 0 || altura <= 0 || lado <= 0)
                throw new ArgumentException("Valores deben ser positivos.");
            Base = baseR;
            Altura = altura;
            Lado = lado;
        }

        public override double CalcularArea()
        {
            return Base * Altura;
        }

        public override double CalcularPerimetro()
        {
            return 2 * (Base + Lado);
        }
    }

}
