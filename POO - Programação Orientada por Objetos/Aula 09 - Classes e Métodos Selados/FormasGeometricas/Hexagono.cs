using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricas
{
    class Hexagono : Forma
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
        public Hexagono(double lado)
        {
            this.lado = lado;
        }
        public override double CalcularArea()
        {
            return (3 * Math.Sqrt(3) / 2) * Math.Pow(lado, 2);
        }
        public override double CalcularPerimetro()
        {
            return lado * 6;
        }
    }
}
