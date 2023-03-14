using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangulo
{
    internal class Tri
    {

        private float A;
        private float B;
        private float C;

        public Tri() { }

        public Tri(float A, float B, float C)
        {

            this.A = A;
            this.B = B;
            this.C = C;
        }

        public void SetA(float A) { this.A = A; }
       
        public float GetA()
        {
            return this.A;
        }

        public void SetB(float B) { this.B = B; }

        public float GetB()
        {
            return this.B;
        }


        public void SetC(float C) { this.C = C; }

        public float GetC()
        {
            ; return this.C;
        }

        public void PrintDados()
        {
            if ((A == B) && (B == C))
            {
                Console.WriteLine("Triangulo Equilatero");
            }

            else if (A >= B + C)
            {
                Console.WriteLine("Nao forma triangulo");
            }

            else if ((A * A == B * B + C * C))
            {
                Console.WriteLine("Triangulo Retangulo");
            }

            else if ((A * A > B * B + C * C))
            {
                Console.WriteLine("Triangulo Obtusangulo");
            }

            else if ((A * A < B * B + C * C))
            {
                Console.WriteLine("Triangulo ACUTANGULO");
            }

            else
            {
                Console.WriteLine("TRIANGULO ISOSCELES");
            }
        }
    }
}
