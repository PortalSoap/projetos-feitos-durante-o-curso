namespace Exercicio_de_Fixação_MembrosEstáticos {
    class ConversorDeMoeda {
        public static double IOF = 6.0;
        public static double Conversao(double cotacaodolar, double valordolar) {
            double OP = cotacaodolar * valordolar;
            return OP + OP * IOF / 100.0; 
        }

    }
}
