using System;
using Herança_Sample.Entities;

namespace Herança_Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exemplo para mostrar que o Programa Principal ainda pode imprimir ou ter acesso a propriedade protected.
            BusinessAccount a = new BusinessAccount(3032, "Bob Brown", 100.0, 500.0);
            Console.WriteLine(a.Balance);

            // Mas não pode alterá-lo.
            // a.Balance = 1000.0;     <-- Isso estaria vermelho caso não fosse um comentário.
        }
    }
}
