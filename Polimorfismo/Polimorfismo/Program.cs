using Polimorfismo.Src;
using Polimorfismo.Src.Especie;
using System;


namespace Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cachorro pluto = new Cachorro("Pluto", 3);
            Gato tom = new Gato("Tom", 2);
            Vaca malu = new Vaca("Malu", 3);
            Jacare renekton = new Jacare("Renekton", 4);

            Console.WriteLine(pluto.fazerBarulho());
            Console.WriteLine(tom.fazerBarulho());
            Console.WriteLine(malu.fazerBarulho());
            Console.WriteLine(renekton.fazerBarulho());

        }
    }
}
