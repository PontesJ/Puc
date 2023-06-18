using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricas
{
    class Retangulo : Forma
    {
        private double largura, comprimento;
        public void setLargura(double largura)
        {
            this.largura = largura;
        }
        public void setComprimento(double comprimento)
        {
            this.comprimento = comprimento;
        }
        public double getLargura()
        {
            return largura;
        }
        public double getComprimento()
        {
            return comprimento;
        }
        public Retangulo(double largura, double comprimento)
        {
            this.largura = largura;
            this.comprimento = comprimento;
        }
        public override double CalcularArea()
        {
            return largura * comprimento;
        }
        public override double CalcularPerimetro()
        {
            return comprimento * 2 + largura * 2;
        }
    }
}
