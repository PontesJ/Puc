using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricas
{
    sealed class Isosceles : Triangulo
    {
        private double lado, baseT;
        public void setLado(double lado)
        {
            this.lado = lado;
        }
        public double getLado()
        {
            return lado;
        }
        public void setBase(double baseT)
        {
            this.baseT = baseT;
        }
        public double getBase()
        {
            return baseT;
        }
        public Isosceles(double lado, double baseT)
        {
            this.lado = lado;
            this.baseT = baseT;
        }
        public override double CalcularArea()
        {
            return baseT * Math.Sqrt(Math.Pow(lado, 2) - Math.Pow(baseT, 2) / 4) / 2;
        }
        public override double CalcularPerimetro()
        {
            return 2 * lado + baseT;
        }
    }
}
