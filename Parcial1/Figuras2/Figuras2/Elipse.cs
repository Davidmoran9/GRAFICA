using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras2
{
    public class Elipse : FiguraGeometrica
    {
        public double EjeMayor { get; set; }
        public double EjeMenor { get; set; }

        public Elipse(double ejeMayor, double ejeMenor)
        {
            if (ejeMayor <= 0 || ejeMenor <= 0)
                throw new ArgumentException("Los ejes deben ser positivos.");
            EjeMayor = ejeMayor;
            EjeMenor = ejeMenor;
        }

        public override double CalcularArea()
        {
            return Math.PI * EjeMayor * EjeMenor;
        }

        public override double CalcularPerimetro()
        {
            // Aproximación de Ramanujan
            double a = EjeMayor;
            double b = EjeMenor;
            return Math.PI * (3 * (a + b) - Math.Sqrt((3 * a + b) * (a + 3 * b)));
        }
    }

}
