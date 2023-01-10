using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dio_dotnet.Common.Models
{
    public class Calculadora
    {
        /// <summary>
        /// Realiza uma soma de dois números
        /// </summary>
        /// <param name="a">O primeiro número inteiro para somar</param>
        /// <param name="b">O segundo número inteiro para somar</param>
        public void Somar(int a, int b) {
            Console.WriteLine($"{a} + {b} = {a + b}");
        }
        public void Subtrair(int a, int b) {
            Console.WriteLine($"{a} - {b} = {a - b}");
        }
        public void Multiplicar(int a, int b) {
            Console.WriteLine($"{a} X {b} = {a * b}");
        }
        public void Dividir(int a, int b) {
            Console.WriteLine($"{a} / {b} = {a / b}");
        }
        public void Potencia(int x, int y) {
            double pot = Math.Pow(x, y);
            Console.WriteLine($"{x} ^ {y} = {pot}");
        }
        public void Seno(double angulo) {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo}° = {Math.Round(seno, 4)}");
        }
        public void Coseno(double angulo) {
            double radiano = angulo * Math.PI / 180;
            double coseno = Math.Cos(radiano);
            Console.WriteLine($"Coseno de {angulo}° = {Math.Round(coseno, 4)}");
        }
        public void Tangente(double angulo) {
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"Tangente de {angulo}° = {Math.Round(tangente, 4)}");
        }
        public void RaizQuadrada(double x) {
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"Raiz quadrada de {x} = {raiz}");
        }
    }
}