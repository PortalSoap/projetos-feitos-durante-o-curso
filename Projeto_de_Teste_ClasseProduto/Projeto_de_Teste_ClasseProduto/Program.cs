using System;

namespace Projeto_de_Teste_ClasseProduto {
    class Program {
        static void Main(string[] args) {
            Produto p = new Produto("TV", 900.0, 10);

            Console.WriteLine(p.Nome);
            p.Nome = "carambolas";
            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
            Console.WriteLine(p.Quantidade);

        }
    }
}
