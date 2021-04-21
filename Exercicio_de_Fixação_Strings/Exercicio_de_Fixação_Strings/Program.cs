using System;
using System.Globalization;

namespace Exercicio_de_Fixação_Strings {
    class Program {
        static void Main(string[] args) {
            string Nome, UltimoNome;
            int Quartos, Idade;
            double Valor, Altura;

            Console.WriteLine("Entre com seu nome completo:");
            Nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa?");
            Quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto:");
            Valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com seu ultimo nome, idade e altura (mesma linha)");
            string[] v = Console.ReadLine().Split(' ');
            UltimoNome = v[0];
            Idade = int.Parse(v[1]);
            Altura = double.Parse(v[2], CultureInfo.InvariantCulture);

            Console.WriteLine(Nome);
            Console.WriteLine(Quartos);
            Console.WriteLine(Valor.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(UltimoNome);
            Console.WriteLine(Idade);
            Console.WriteLine(Altura.ToString("F2", CultureInfo.InvariantCulture));










        }
    }
}
