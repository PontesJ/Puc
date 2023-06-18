using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricas
{
    class Pentagono : Forma
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
        public Pentagono(double lado)
        {
            this.lado = lado;
        }
        public override double CalcularArea()
        {
            return (5.0 / 4.0) * Math.Pow(lado, 2) * (1.0 / Math.Tan(Math.PI / 5.0));
        }
        public override double CalcularPerimetro()
        {
            return lado * 5;
        }
    }
}
