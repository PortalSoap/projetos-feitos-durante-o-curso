using System;

namespace Exercicio1_Programação_Orientada_a_Objetos {
    class Triangulo {
        public double A;
        public double B;
        public double C;

        public double Area() {
            double p = (A + B + C) / 2.0;
            double media = Math.Sqrt(p * (p - A) * (p - B) * (p - C));

            return media;
        }
    }
}
