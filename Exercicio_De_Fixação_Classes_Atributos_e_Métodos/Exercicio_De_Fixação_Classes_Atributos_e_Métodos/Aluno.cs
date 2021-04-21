using System.Globalization;

namespace Exercicio_De_Fixação_Classes_Atributos_e_Métodos {
    class Aluno {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double NotaFinal() {
            double op = Nota1 + Nota2 + Nota3;
            return (op);
        }

        public double PontosFaltantes() {
            double op = 60.0 - NotaFinal();
            return (op);
        }
    }
}
