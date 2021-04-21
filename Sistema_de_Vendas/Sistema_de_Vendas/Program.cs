using System;
using System.Globalization;

namespace Sistema_de_Vendas {
    class Program {
        static void Main(string[] args) {
            //Dados básicos de saída e introdução a varíaveis e vetor

            int N;
            double[] vetor;
            Console.WriteLine("Seja bem-vindo ao BurguerShop!");
            Console.WriteLine();
            Console.WriteLine("1 - HAMBURGUER DE FRANGO R$ 4.45");
            Console.WriteLine("2 - HAMBURGUER DE CARNE BOVINA R$5.00");
            Console.WriteLine("3 - REFRIGERANTE PEPSI 300ml R$3.30 ");
            Console.WriteLine("4 - SUCO NATURAL 500ml (QUALQUER SABOR) R$ 3.00");
            Console.WriteLine();
            Console.Write("Quantidade de produtos: ");

            //Sistema utilizando o 'for' para guardar os códigos de produtos escritos na mesma linha (separados por espaço)

            N = int.Parse(Console.ReadLine());
            vetor = new double[N];

            double soma = 0.0;
            Console.Write("Produtos: ");
            string[] v = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++) {
                vetor[i] = int.Parse(v[i]);

                while (vetor[i] < 1 || vetor[i] > 4) {
                    Console.WriteLine("Produto invalido");
                    Console.Write("Produto faltante: ");
                    v[i] = Console.ReadLine();
                    vetor[i] = double.Parse(v[i]);
                }

                if (vetor[i] == 1) {

                }
                else if (vetor[i] == 2) {
                    soma += 5.00;
                }
                else if (vetor[i] == 3) {
                    soma += 3.30;
                }
                else {
                    soma += 3.00;
                }
            }

            //Saída informando a soma dos valores de cada produto

            Console.WriteLine($"TOTAL: R$ {soma.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.WriteLine();

            //Parte inicial do sistema para 

            double Valorpago, Troco;
            Console.Write("Total pago pelo cliente: R$");
            Valorpago = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Troco = Valorpago - soma;
            Console.WriteLine($"Troco do cliente: {Troco.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.WriteLine();
            Console.WriteLine("NOTAS");
            Console.WriteLine();

            double nota, resto;
            int operacao;

            nota = 100.0;
            operacao = (int)(Troco / nota);
            Console.WriteLine($"Moedas de R${nota.ToString("F2", CultureInfo.InvariantCulture)}: {operacao}");
            resto = Troco % nota;

            nota = 50.0;
            operacao = (int)(resto / nota);
            Console.WriteLine($"Moedas de R${nota.ToString("F2", CultureInfo.InvariantCulture)}: {operacao}");
            resto = resto % nota;

            nota = 20.0;
            operacao = (int)(resto / nota);
            Console.WriteLine($"Moedas de R${nota.ToString("F2", CultureInfo.InvariantCulture)}: {operacao}");
            resto = resto % nota;

            nota = 10.0;
            operacao = (int)(resto / nota);
            Console.WriteLine($"Moedas de R${nota.ToString("F2", CultureInfo.InvariantCulture)}: {operacao}");
            resto = resto % nota;

            nota = 5.0;
            operacao = (int)(resto / nota);
            Console.WriteLine($"Moedas de R${nota.ToString("F2", CultureInfo.InvariantCulture)}: {operacao}");
            resto = resto % nota;

            nota = 2.0;
            operacao = (int)(resto / nota);
            Console.WriteLine($"Moedas de R${nota.ToString("F2", CultureInfo.InvariantCulture)}: {operacao}");
            resto = resto % nota;

            Console.WriteLine();
            Console.WriteLine("MOEDAS");
            Console.WriteLine();

            double moeda;

            moeda = 1.0;
            operacao = (int)(resto / moeda);
            Console.WriteLine($"Moedas de R${moeda.ToString("F2", CultureInfo.InvariantCulture)}: {operacao}");
            resto = resto % moeda;

            moeda = 0.50;
            operacao = (int)(resto / moeda);
            Console.WriteLine($"Moedas de R${moeda.ToString("F2", CultureInfo.InvariantCulture)}: {operacao}");
            resto = resto % moeda;

            moeda = 0.25;
            operacao = (int)(resto / moeda);
            Console.WriteLine($"Moedas de R${moeda.ToString("F2", CultureInfo.InvariantCulture)}: {operacao}");
            resto = resto % moeda;

            moeda = 0.10;
            operacao = (int)(resto / moeda);
            Console.WriteLine($"Moedas de R${moeda.ToString("F2", CultureInfo.InvariantCulture)}: {operacao}");
            resto = resto % moeda;

            moeda = 0.5;
            operacao = (int)(resto / moeda);
            Console.WriteLine($"Moedas de R${moeda.ToString("F2", CultureInfo.InvariantCulture)}: {operacao}");

            Console.ReadLine();


        }
    }
}
