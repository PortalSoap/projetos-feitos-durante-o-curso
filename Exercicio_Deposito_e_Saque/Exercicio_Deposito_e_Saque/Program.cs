using System;
using System.Globalization;

namespace Exercicio_Deposito_e_Saque {
    class Program {
        static void Main(string[] args) {
            Console.Write("Entre o número da conta: ");
            int conta = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            string escolha = Console.ReadLine();

            ContaBancaria c = new ContaBancaria(conta, titular, 0.0);

            if(escolha == "s") {
                Console.Write("Entre o valor de depósito incial: ");
                double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c = new ContaBancaria(conta, titular, saldo);
            }

            Console.WriteLine("Dados da conta:");
            Console.WriteLine(c);
            
            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Deposito(deposito);

            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(c);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Saque(saque);

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(c);

        }
    }
}
