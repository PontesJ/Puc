using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricas
{
    sealed class Circulo : Forma
    {
        private double raio;
        public void setRaio(double raio)
        {
            this.raio = raio;
        }
        public double getRaio()
        {
            return raio;
        }
        public Circulo(double raio)
        {
            this.raio = raio;
        }
        public override double CalcularArea()
        {
            return Math.PI * (raio * raio);
        }
        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * raio;
        }
    }
}
