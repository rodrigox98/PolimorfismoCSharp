using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo.Src.Especie
{
    internal class Jacare : Animal
    {
        public Jacare(string nome, int idade) : base(nome, idade)
        {
        }

        public override string fazerBarulho()
        {
            return "Jacaré fazendo barulho(n sei que barulho o jacaré faz kkk)";
        }

    }

}
