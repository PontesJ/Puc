using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricas
{
    sealed class Equilatero : Triangulo
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
        public Equilatero(double lado)
        {
            this.lado = lado;
        }
        public override double CalcularArea()
        {
            return Math.Sqrt(3) / 4 * Math.Pow(lado, 2);
        }
        public override double CalcularPerimetro()
        {
            return 3 * lado;
        }
    }
}