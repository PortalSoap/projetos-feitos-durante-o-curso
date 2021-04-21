using System;
using System.Globalization;

namespace Exercicio2_EstruturaCondicional {
    class Program {
        static void Main(string[] args) {
            byte escolha;
            Console.WriteLine("Qual o exercicio?");
            Console.Write("R: ");
            escolha = byte.Parse(Console.ReadLine());

            if (escolha < 1 || escolha > 8) {
                Console.WriteLine("Qual o exercicio?");
                Console.Write("R: ");
                escolha = byte.Parse(Console.ReadLine());
            }

            else if (escolha == 1) {
                // Exercicio 1
                int numero;
                numero = int.Parse(Console.ReadLine());
                if (numero < 0) {
                    Console.WriteLine("NEGATIVO");
                }
                else {
                    Console.WriteLine("NAO NEGATIVO");
                }
            }

            else if(escolha == 2) {
                // Exercicio 2
                int numero;
                numero = int.Parse(Console.ReadLine());
                if(numero == 0) {
                    Console.WriteLine("PAR");
                }
                else if(numero % 2 != 0) {
                    Console.WriteLine("IMPAR");
                }
                else {
                    Console.WriteLine("PAR");
                }
            }

            else if(escolha == 3) {
                // Exercico 3
                int x, y;
                string[] v = Console.ReadLine().Split(' ');
                x = int.Parse(v[0]);
                y = int.Parse(v[1]);
                if(y % x == 0 || x % y == 0) {
                    Console.WriteLine("Sao Multiplos");
                }
                else {
                    Console.WriteLine("Nao sao Multiplos");
                }
            }

            else if(escolha == 4) {
                // Exercicio 4
                int horainicial, horafinal, duração;
                string[] v = Console.ReadLine().Split(' ');
                horainicial = int.Parse(v[0]);
                horafinal = int.Parse(v[1]);
                duração = 0;

                if(horainicial < horafinal) {
                    duração = horafinal - horainicial;
                }
                else {
                    duração = 24 - horainicial + horafinal;
                }

                Console.WriteLine($"O JOGO DUROU {duração} HORA(S)");
            }

            else if(escolha == 5) {
                // Exercicio 5
                int codigo, quantidade;
                double soma;
                string[] v = Console.ReadLine().Split(' ');
                codigo = int.Parse(v[0]);
                quantidade = int.Parse(v[1]);
                soma = 0.0;
                if(codigo == 1) {
                    soma = (double)(4.0 * quantidade);
                }
                else if(codigo == 2) {
                    soma = (double)(4.5 * quantidade);
                }
                else if(codigo == 3) {
                    soma = (double)(5.0 * quantidade);
                }
                else if(codigo == 4) {
                    soma = (double)(2.0 * quantidade);
                }
                else {
                    soma = (double)(1.5 * quantidade);
                }
                Console.WriteLine($"Total: R$ {soma.ToString("F2", CultureInfo.InvariantCulture)}");
            }

            else if(escolha == 6) {
                // Exercicio 6
                double valor;
                valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(valor < 0.0 || valor > 100.0) {
                    Console.WriteLine("Fora de intervalo");
                }
                else if(valor >= 0.0 && valor <= 25.0) {
                    Console.WriteLine("Intervalo [0,25]");
                }
                else if(valor <= 50.0) {
                    Console.WriteLine("Intervalo (25,50]");
                }
                else if(valor <= 75.0) {
                    Console.WriteLine("Intervalo (50,75]");
                }
                else {
                    Console.WriteLine("Intervalo (75,100]");
                }
            }

            else if(escolha == 7) {
                // Exercicio 7
                double x, y;
                string[] v = Console.ReadLine().Split(' ');
                x = double.Parse(v[0], CultureInfo.InvariantCulture);
                y = double.Parse(v[1], CultureInfo.InvariantCulture);
                if(x == 0.0 && y == 0.0) {
                    Console.WriteLine("Origem");
                }
                else if(x > 0.0 && y > 0.0) {
                    Console.WriteLine("Q1");
                }
                else if(x < 0.0 && y > 0.0) {
                    Console.WriteLine("Q2");
                }
                else if(x < 0.0 && y < 0.0) {
                    Console.WriteLine("Q3");
                }
                else {
                    Console.WriteLine("Q4");
                }
            }

            else {
                // Exercicio 8
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                double imposto;
                if (salario <= 2000.0) {
                    imposto = 0.0;
                }
                else if (salario <= 3000.0) {
                    imposto = (salario - 2000.0) * 0.08;
                }
                else if (salario <= 4500.0) {
                    imposto = (salario - 3000.0) * 0.18 + 1000.0 * 0.08;
                }
                else {
                    imposto = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
                }
                if (imposto == 0.0) {
                    Console.WriteLine("Isento");
                }
                else {
                    Console.WriteLine($"R$ {imposto.ToString("F2", CultureInfo.InvariantCulture)}");
                }
            }


        }
    }
}
