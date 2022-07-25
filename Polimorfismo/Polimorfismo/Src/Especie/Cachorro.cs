using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Polimorfismo.Src.Especie
{
    internal class Cachorro : Animal
    {
        public Cachorro(string nome, int idade) : base(nome, idade)
        {
        }
        public override string fazerBarulho()
        {
            return "Au au au";
        }
    }
}
