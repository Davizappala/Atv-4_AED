using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using triangulo;

namespace AtvAed4
{
    internal class Triangulo
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Tipo de triangulo");
            Tri p1 = new Tri();
            Console.WriteLine("Digite o valor de A");

            p1.SetA(float.Parse(Console.ReadLine()));
            Console.WriteLine("Digite o valor de B");
            p1.SetB(float.Parse(Console.ReadLine()));
            Console.WriteLine("Digite o valor de C");
            p1.SetC(float.Parse(Console.ReadLine()));

            Console.WriteLine("O valor de A é: " + p1.GetA());
            Console.WriteLine("O valor de B é: " + p1.GetB());
            Console.WriteLine("O valor de C é: " + p1.GetC());


            p1.PrintDados();
        }
    }
}