using System.Globalization;

namespace Exercicio_De_Fixação_Classes_Atributos_e_Métodos {
    class Funcionario {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido() {
            double op = SalarioBruto - Imposto;
            return (op);
        }

        public void AumentarSalario(double porcentagem) {
            SalarioBruto += porcentagem / 100 * SalarioBruto;
        }

        public override string ToString() {
            return Nome + ", "
                + "$ " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
