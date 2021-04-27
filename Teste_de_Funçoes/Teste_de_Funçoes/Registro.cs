using System;
using System.Collections.Generic;

namespace Teste_de_Funçoes
{
    class Registro
    {

        static private int _posicao;
        static public List<Pessoa> ListaRegistro = new List<Pessoa>();

        static public void Add(Pessoa p)
        {
            ListaRegistro.Add(p);

            Console.WriteLine("Pessoa Adicionada!");
            Console.WriteLine();
        }

        static public void Remove(int posicao)
        {
            if (ListaRegistro.Count > 0)
            {
                ListaRegistro.RemoveAt(posicao);

                Console.WriteLine("Pessoa Removida!");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Nenhuma pessoa foi removida!");
                Console.WriteLine();
            }
        }

        static public void Consult()
        {
            if (ListaRegistro.Count > 0)
            {
                Console.WriteLine("Pessoas cadastradas:");
                foreach (Pessoa obj in ListaRegistro)
                {
                    Console.WriteLine(_posicao + ": " + obj);
                    _posicao++;
                }
                _posicao = 0;
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Não há nada para consultar.");
            }
        }
    }
}
