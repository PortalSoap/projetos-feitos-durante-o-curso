using System;
using System.Collections.Generic;

namespace Teste_de_Funçoes {
    class Program {
        static void Main(string[] args) {

            // Declaração e adição de nomes na lista.
            List<string> nomes = new List<string>();
            nomes.Add("Maria");
            nomes.Add("Alex");
            nomes.Add("Bob");
            nomes.Add("Ana");
            nomes.Insert(2, "Marco");

            foreach (string obj in nomes) {
                Console.WriteLine(obj);
            }

            // Função para saber o tamanho de uma lista (função junto com a impressão).
            Console.WriteLine("List count: " + nomes.Count);

            // Função para encontrar primeira ocorrência com base em um predicado.
            string s1 = nomes.Find(x => x[0] == 'A');
            Console.WriteLine("First 'A': " + s1);

            // Função para encontrar última ocorrência com base em um predicado.
            string s2 = nomes.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A': " + s2);

            // Função para encontrar uma posição com base em um predicado (só guarda a primeira ocorrência).
            int pos1 = nomes.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A': " + pos1);

            // Função para encontrar uma posição com base em um predicado (só guarda a última ocorrência).
            int pos2 = nomes.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position 'A': " + pos2); // impressão

            // Função para encontrar ocorrências com base em um predicado e alocar as ocorrências em uma outra lista.
            Console.WriteLine("----------------------");
            List<string> nome5length = nomes.FindAll(x => x.Length == 5);
            foreach (string obj in nome5length) { // impressão
                Console.WriteLine(obj);
            }

            // Função para remover itens específicos duma lista.
            nomes.Remove("Alex");
            Console.WriteLine("----------------------");
            foreach (string obj in nomes) { // impressão
                Console.WriteLine(obj);
            }

            // Função para remover itens com base em um predicado.
            nomes.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("----------------------");
            foreach (string obj in nomes) { // impressão
                Console.WriteLine(obj);
            }

            //Função para remover itens com base em uma posição.
            nomes.RemoveAt(0);
            Console.WriteLine("----------------------");
            foreach (string obj in nomes) { // impressão
                Console.WriteLine(obj);
            }

            // Adicionar novamente os itens para exemplo da última função.
            nomes.RemoveAll(x => x.Length < 10);
            nomes.Add("Maria");
            nomes.Add("Alex");
            nomes.Add("Bob");
            nomes.Add("Ana");
            nomes.Insert(2, "Marco");

            // Remover X itens a partir duma posição 
            // (primeiro número é a partir da onde se deve remover 
            // e o segundo número é o total de itens a remover, contando com o número da posição de onde começa.)
            nomes.RemoveRange(2, 2);
            Console.WriteLine("----------------------");
            foreach (string obj in nomes) { // impressão
                Console.WriteLine(obj);
            }
        }
    }
}
