using System;
using Polimorfismo2.Src;
namespace Polimorfismo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadrado quadrado = new Quadrado(15, 10);
            Retangulo retangulo = new Retangulo(15, 10);
            Triangulo triangulo = new Triangulo(15, 10);


                Console.WriteLine("Calcular a área dos 3 objetos, base = 15m, altura = 10m");

            Console.WriteLine("Área do quadrado: " + quadrado.calcularArea() + " m2");
            Console.WriteLine("Área do retângulo: " + retangulo.calcularArea() + " m2");

            //Único método a ser sobrescrito: 
            Console.WriteLine("Área do triângulo: " + triangulo.calcularArea() + " m2");
        }
    }
}
