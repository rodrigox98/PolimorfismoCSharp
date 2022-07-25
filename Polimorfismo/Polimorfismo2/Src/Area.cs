using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo2.Src
{
    internal class Area
    {
        public double Altura { get; set; }

        public double Base {get; set;}

        public Area( double altura, double @base)
        {
            Altura = altura;
            Base = @base;
        }

        public virtual double calcularArea()
        {
            return Base * Altura;
        }
    }
}
