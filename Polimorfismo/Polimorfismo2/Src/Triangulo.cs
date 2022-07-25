using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo2.Src
{
    internal class Triangulo : Area
    {
        public Triangulo(double altura, double @base): base(altura, @base)
        {

        }

        public override double calcularArea()
        {
            return (Base * Altura) / 2;
        }
    }
}
