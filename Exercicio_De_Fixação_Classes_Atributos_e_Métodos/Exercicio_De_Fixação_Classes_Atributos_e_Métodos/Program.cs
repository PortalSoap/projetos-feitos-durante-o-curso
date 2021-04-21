using System;
using System.Globalization;
using System.Transactions;

namespace Exercicio_De_Fixação_Classes_Atributos_e_Métodos {
    class Program {
        static void Main(string[] args) {
            byte escolha;
            Console.WriteLine("Qual é o exercicio?");
            Console.Write("R: ");
            escolha = byte.Parse(Console.ReadLine());

            if (escolha < 1 || escolha > 3) {
                Console.WriteLine("Qual é o exercicio?");
                Console.Write("R: ");
                escolha = byte.Parse(Console.ReadLine());
            }

            else if (escolha == 1) {
                // Exercicio 1
                Retangulo r;
                r = new Retangulo();

                Console.WriteLine("Entre a largura e altura do retângulo:");
                r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine($"AREA = {r.Area().ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"PERÍMETRO = {r.Perimetro().ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"DIAGONAL = {r.Diagonal().ToString("F2", CultureInfo.InvariantCulture)}");
            }

            else if(escolha == 2) {
                // Exercicio 2
                Funcionario f;
                f = new Funcionario();

                Console.Write("Nome: ");
                f.Nome = Console.ReadLine();
                Console.Write("Salário Bruto: ");
                f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Imposto: ");
                f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                Console.WriteLine();
                Console.WriteLine($"Funcionário {f}");

                Console.WriteLine();
                Console.Write("Digite a porcentagem para aumentar o salário: ");
                double porcentagem;
                porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                f.AumentarSalario(porcentagem);

                Console.WriteLine();
                Console.WriteLine($"Dados atualizados: {f}");
            }

            else {
                // Exercicio 3
                Aluno a;
                a = new Aluno();

                Console.Write("Nome do aluno: ");
                a.Nome = Console.ReadLine();
                Console.WriteLine("Digite as três notas do aluno:");
                a.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                a.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                a.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine($"NOTA FINAL = {a.NotaFinal().ToString("F2", CultureInfo.InvariantCulture)}");
                
                if(a.NotaFinal() >= 60.0) {
                    Console.WriteLine("APROVADO");
                }

                else {
                    Console.WriteLine("REPROVADO");
                    Console.WriteLine($"FALTARAM {a.PontosFaltantes().ToString("F2", CultureInfo.InvariantCulture)} PONTOS");
                }

            }

        }
    }
}
