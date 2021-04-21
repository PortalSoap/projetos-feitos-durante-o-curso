using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Reflection.Metadata;

namespace Exercicio3_EstruturaWhile {
    class Program {
        static void Main(string[] args) {
            byte escolha;
            Console.WriteLine("Qual o exercicio?");
            Console.Write("R: ");
            escolha = byte.Parse(Console.ReadLine());

            if (escolha < 1 || escolha > 3) {
                Console.WriteLine("Qual o exercicio?");
                Console.Write("R: ");
                escolha = byte.Parse(Console.ReadLine());
            }
            else if (escolha == 1) {
                // Exercicio 1
                int senha;
                senha = int.Parse(Console.ReadLine());
                while (senha != 2002) {
                    Console.WriteLine("Senha invalida");
                    senha = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Acesso Permitido");
            }

            else if(escolha == 2) {
                // Exercicio 2
                int x, y;
                string[] v = Console.ReadLine().Split(' ');
                x = int.Parse(v[0]);
                y = int.Parse(v[1]);
                while(x != 0 && y != 0) {
                    if(x > 0 && y > 0) {
                        Console.WriteLine("primeiro");
                    }
                    else if(x < 0 && y > 0) {
                        Console.WriteLine("segundo");
                    }
                    else if(x < 0 && y < 0) {
                        Console.WriteLine("terceiro");
                    }
                    else {
                        Console.WriteLine("quarto");
                    }
                }
            }

            else {
                int produto, Alcool, Diesel, Gasolina;
                produto = int.Parse(Console.ReadLine());
                Alcool = 0;
                Diesel = 0;
                Gasolina = 0;
                
                while(produto != 4) {
                    while (produto < 0 || produto > 4) {
                        produto = int.Parse(Console.ReadLine());
                    }
                    if (produto == 1) {
                        Alcool++;
                    }
                    else if(produto == 2) {
                        Gasolina++;
                    }
                    else {
                        Diesel++;
                    }
                    produto = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("MUITO OBRIGADO");
                Console.WriteLine($"Alcool: {Alcool}");
                Console.WriteLine($"Gasolina: {Gasolina}");
                Console.WriteLine($"Diesel: {Diesel}");
            }





        }
    }
}
