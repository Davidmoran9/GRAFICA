using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras2
{
    public class Circulo : FiguraGeometrica
    {
        public double Radio { get; set; }

        public Circulo(double radio)
        {
            if (radio <= 0)
                throw new ArgumentException("El radio debe ser positivo.");
            Radio = radio;
        }

        public override double CalcularArea()
        {
            double area = Math.PI * Math.Pow(Radio, 2);
            return Math.Round(area, 4); 
        }

        public override double CalcularPerimetro()
        {
            double perimetro = 2 * Math.PI * Radio;
            return Math.Round(perimetro, 4);
        }
    }

}
