using System;
using System.Globalization;

namespace Exercicio_de_Fixação_MembrosEstáticos {
    class Program {
        static void Main(string[] args) {
            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            double dolares = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double ValorFinal = ConversorDeMoeda.Conversao(cotacao, dolares);
            Console.WriteLine("Valor a ser pago em reais = " + ValorFinal.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
