using System;

namespace Exercicio_De_Fixação_Classes_Atributos_e_Métodos {
    class Retangulo {
        public double Largura;
        public double Altura;

        public double Area() {
            double op = Largura * Altura;
            return (op);
        }

        public double Perimetro() {
            double op = (Largura * 2) + (Altura * 2);
            return (op);
        }

        public double Diagonal() {
            double op = Math.Sqrt(((Largura * Largura) + (Altura * Altura)));
            return (op);
        }

    }
}
