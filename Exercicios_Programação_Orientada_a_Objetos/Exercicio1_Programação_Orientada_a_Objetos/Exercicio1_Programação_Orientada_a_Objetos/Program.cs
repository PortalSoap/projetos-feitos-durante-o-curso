using Exercico_de_Fixação_Classes;
using System;
using System.Globalization;

namespace Exercicio1_Programação_Orientada_a_Objetos {
    class Program {
        static void Main(string[] args) {
            byte escolha;
            Console.WriteLine("Qual é o exercicio?");
            Console.Write("R: ");
            escolha = byte.Parse(Console.ReadLine());

            if (escolha < 1 || escolha > 2) {
                Console.WriteLine("Qual é o exercicio?");
                Console.Write("R: ");
                escolha = byte.Parse(Console.ReadLine());
            }

            else if (escolha == 1) {
                // Exercicio 1
                Pessoa a, b;
                a = new Pessoa();
                b = new Pessoa();

                Console.WriteLine("Dados da primeira pessoa:");
                Console.Write("Nome: ");
                a.Nome = Console.ReadLine();
                Console.Write("Idade: ");
                a.Idade = int.Parse(Console.ReadLine());

                Console.WriteLine("Dados da segunda pessoa:");
                Console.Write("Nome: ");
                b.Nome = Console.ReadLine();
                Console.Write("Idade: ");
                b.Idade = int.Parse(Console.ReadLine());

                if (a.Idade > b.Idade) {
                    Console.WriteLine($"Pessoa mais velha: {a.Nome}");
                }

                else {
                    Console.WriteLine($"Pessoa mais velha: {b.Nome}");
                }
            }

            else {
                // Exercicio 2
                Funcionario f1, f2;
                f1 = new Funcionario();
                f2 = new Funcionario();

                Console.WriteLine("Dados do primeiro funcionário:");
                Console.Write("Nome: ");
                f1.Nome = Console.ReadLine();
                Console.Write("Salário: ");
                f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine("Dados do segundo funcionário: ");
                Console.Write("Nome: ");
                f2.Nome = Console.ReadLine();
                Console.Write("Salário: ");
                f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double media = (f1.Salario + f2.Salario) / 2;

                Console.WriteLine($"Salário médio = {media.ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}
