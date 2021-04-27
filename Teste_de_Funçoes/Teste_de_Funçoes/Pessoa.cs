using System;

namespace Teste_de_Funçoes
{
    class Pessoa
    {
        public int NumeroRegistro { get; private set; }
        public string Nome { get; private set; }
        public long CPF { get; private set; }
        public DateTime DataNascimento { get; private set; }

        public Pessoa()
        {
            NumeroRegistro = 0;
            Nome = "Pessoa";
            CPF = 12345678910;
            DataNascimento = DateTime.Parse("1-1-1999");
        }

        public Pessoa(int registro, string nome, long cpf, DateTime data)
        {
            NumeroRegistro = registro;
            Nome = nome;
            CPF = cpf;
            DataNascimento = data;
        }

        public override string ToString()
        {
            return "Nº de Registro: " + NumeroRegistro
                + ", " + Nome
                + ", CPF: " + CPF
                + ", Data de Nascimento: " + DataNascimento.ToShortDateString();
        }
    }
}
