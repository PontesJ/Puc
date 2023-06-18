using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricas
{
    sealed class Escaleno : Triangulo
    {
        private double ladoA, ladoB, ladoC;
        public void setLadoA(double ladoA)
        {
            this.ladoA = ladoA;
        }
        public void setLadoB(double ladoB)
        {
            this.ladoB = ladoB;
        }
        public void setLadoC(double ladoC)
        {
            this.ladoC = ladoC;
        }
        public double getLadoA()
        {
            return ladoA;
        }
        public double getLadoB()
        {
            return ladoB;
        }
        public double getLadoC()
        {
            return ladoC;
        }
        public Escaleno(double ladoA, double ladoB, double ladoC)
        {
            this.ladoA = ladoA;
            this.ladoB = ladoB;
            this.ladoC = ladoC;
        }
        public override double CalcularArea()
        {
            double aux = (ladoA + ladoB + ladoC) / 2;
            return Math.Sqrt(aux * (aux - ladoA) * (aux - ladoB) * (aux - ladoC));
        }
        public override double CalcularPerimetro()
        {
            return ladoA + ladoB + ladoC;
        }
    }
}
