using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricas
{
    abstract class Triangulo : Forma
    {
        public abstract override double CalcularArea();
        public abstract override double CalcularPerimetro();
    }
}
