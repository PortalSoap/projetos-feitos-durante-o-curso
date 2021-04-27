using System;

namespace Teste_de_Funçoes
{
    class Program
    {
        static void Main(string[] args)
        {

            int registro, posicao;
            string nome, comando;
            long cpf;
            DateTime data;
            Pessoa p = new Pessoa();

            Console.Write("Comando: ");
            comando = Console.ReadLine();
            Console.WriteLine();

            while (comando != "off")
            {
                while (comando != "off" && comando != "add"
                && comando != "remove" && comando != "consult")
                {
                    Console.WriteLine("Comando inválido.");
                    Console.Write("Comando: ");
                    comando = Console.ReadLine();
                    Console.WriteLine();
                }

                if (comando == "help")
                {
                    Console.WriteLine("Comandos:");
                    Console.WriteLine("add - adicionar pessoa.");
                    Console.WriteLine("remove - remover pessoa.");
                    Console.WriteLine("consult - consultar índice.");
                    Console.WriteLine("off - encerrar programa.");
                }

                if (comando == "add")
                {
                    Console.Write("Nº de Registro: ");
                    registro = int.Parse(Console.ReadLine());

                    Console.Write("Nome: ");
                    nome = Console.ReadLine();

                    Console.Write("CPF: ");
                    cpf = long.Parse(Console.ReadLine());

                    Console.Write("Data de Nascimento: ");
                    data = DateTime.Parse(Console.ReadLine());

                    p = new Pessoa(registro, nome, cpf, data);
                    Registro.Add(p);
                }

                if (comando == "remove")
                {
                    Console.Write("Pessoa a ser removida (por índice): ");
                    posicao = int.Parse(Console.ReadLine());
                    Registro.Remove(posicao);
                }

                if (comando == "consult")
                {
                    Registro.Consult();
                }

                Console.Write("Comando: ");
                comando = Console.ReadLine();
                Console.WriteLine();
            }
        }
    }
}
