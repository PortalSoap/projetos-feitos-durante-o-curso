using System;
using System.Globalization;

namespace Exercicio1_Programação_Orientada_a_Objetos {
    class Program {
        static void Main(string[] args) {
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triangulo X:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triangulo Y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areax = x.Area();
            double areay = y.Area();

            Console.WriteLine($"Área de X: {areax.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Área de Y: {areay.ToString("F4", CultureInfo.InvariantCulture)}");

            if (areax > areay) {
                Console.WriteLine("Maior área: X");
            }

            else {
                Console.WriteLine("Maior área Y");
            }

        }
    }
}