using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricas
{
    sealed class Quadrado : Forma
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
        public Quadrado(double lado)
        {
            this.lado = lado;
        }
        public override double CalcularArea()
        {
            return lado * lado;
        }
        public override double CalcularPerimetro()
        {
            return lado * 4;
        }
    }
}
