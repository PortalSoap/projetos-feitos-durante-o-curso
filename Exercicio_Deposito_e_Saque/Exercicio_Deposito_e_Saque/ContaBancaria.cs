using System.Globalization;

namespace Exercicio_Deposito_e_Saque {
    class ContaBancaria {

        private double _taxa = 5.0;
        public int Conta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { private get; set; }
        

        public ContaBancaria(int conta, string titular) {
            Conta = conta;
            Titular = titular;
        }

        public ContaBancaria(int conta, string titular, double saldo) : this( conta, titular){
            Deposito(saldo); 
        }

        public void Deposito(double deposito) {
            Saldo += deposito;
        }

        public void Saque(double saque) {
            Saldo -= saque;
            Saldo -= _taxa;
        }

        public override string ToString() {
            return "Conta " + Conta
                + ", Titular: " + Titular
                + ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
