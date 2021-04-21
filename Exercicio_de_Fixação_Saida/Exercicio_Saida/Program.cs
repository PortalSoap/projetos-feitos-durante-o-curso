using System;
using System.Globalization;

namespace Exercicio_Saida {
    class Program {
        static void Main(string[] args) {
            
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preço1 = 2100.0;
            double preço2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo preço é $ {preço1:F2}");
            Console.WriteLine($"{produto2}, cujo preço é $ {preço2:F2}");
            Console.WriteLine();
            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e genero: {genero}");
            Console.WriteLine();
            Console.WriteLine($"Medida com oito casas decimais: {medida:F8}");
            Console.WriteLine($"Arredondado (três casas decimais): {medida:F3}");
            Console.WriteLine($"Separador decimal invariant culture: {medida:F3}");
            Console.ReadLine();









        }
    }
}
