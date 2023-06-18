using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricas
{
    class Octogono : Forma
    {
        private double lado;
        public void setLado(double lado)
        {
            this.lado = lado;
        }
        public double getLado()
        {
            return lado;
        }
        public Octogono(double lado)
        {
            this.lado = lado;
        }
        public override double CalcularArea()
        {
            return 2 * (1 + Math.Sqrt(2)) * Math.Pow(lado, 2);
        }
        public override double CalcularPerimetro()
        {
            return lado * 8;
        }
    }
}
