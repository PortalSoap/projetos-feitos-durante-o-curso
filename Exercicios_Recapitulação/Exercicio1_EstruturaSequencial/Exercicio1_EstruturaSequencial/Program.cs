using System;
using System.Globalization;
using System.Reflection;
using System.Text;

namespace Exercicio1_EstruturaSequencial {
    class Program {
        static void Main(string[] args) {
            byte escolha;
            Console.WriteLine("Qual o exercicio?");
            Console.Write("R: ");
            escolha = byte.Parse(Console.ReadLine());

            if(escolha < 1 || escolha > 6) {
                Console.WriteLine("Qual o exercicio?");
                Console.Write("R: ");
                escolha = byte.Parse(Console.ReadLine());
            }

            else if (escolha == 1) {
                // Exercicio 1
                byte x = byte.Parse(Console.ReadLine()),
                    y = byte.Parse(Console.ReadLine());

                int soma = x + y;
                Console.WriteLine($"SOMA = {soma}");
                Console.WriteLine();
            }

            else if (escolha == 2) {
                // Exercicio 2
                double raio, pi, area;
                pi = 3.14159;
                raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                area = pi * (raio * raio);

                Console.WriteLine($"A={area.ToString("F4", CultureInfo.InvariantCulture)}");
            }

            else if(escolha == 3) {
                int a, b, c, d, diferença;
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                c = int.Parse(Console.ReadLine());
                d = int.Parse(Console.ReadLine());
                diferença = a * b - c * d;

                Console.WriteLine($"DIFERENCA = {diferença}");
            }

            else if(escolha == 4) {
                int funcionario, horas;
                double salario_por_hora, salario;

                funcionario = int.Parse(Console.ReadLine());
                horas = int.Parse(Console.ReadLine());
                salario_por_hora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                salario = (double) (horas * salario_por_hora);

                Console.WriteLine($"NUMBER = {funcionario}");
                Console.WriteLine($"SALARY = U$ {salario.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            
            else if(escolha == 5) {
                int codigo1, codigo2, unidade1, unidade2;
                double valor1, valor2, total1, total2, totalfinal;
                
                string[] v = Console.ReadLine().Split(' ');
                codigo1 = int.Parse(v[0]);
                unidade1 = int.Parse(v[1]);
                valor1 = double.Parse(v[2], CultureInfo.InvariantCulture);
                total1 = (Double) (unidade1 * valor1);

                v = Console.ReadLine().Split(' ');
                codigo2 = int.Parse(v[0]);
                unidade2 = int.Parse(v[1]);
                valor2 = double.Parse(v[2], CultureInfo.InvariantCulture);
                total2 = (Double)(unidade2 * valor2);

                totalfinal = total1 + total2;
                Console.WriteLine($"VALOR A PAGAR: R$ {totalfinal.ToString("F2", CultureInfo.InvariantCulture)}");
            }

            else {
                double a, b, c, pi,
                    triangulo, circulo, trapezio, quadrado, retangulo;
                string[] v = Console.ReadLine().Split(' ');
                a = double.Parse(v[0], CultureInfo.InvariantCulture);
                b = double.Parse(v[1], CultureInfo.InvariantCulture);
                c = double.Parse(v[2], CultureInfo.InvariantCulture);
                pi = 3.14159;

                triangulo = (a * c) / 2;
                circulo = pi * (c * c);
                trapezio = ((a + b) * c) / 2;
                quadrado = b * b;
                retangulo = a * b;

                Console.WriteLine($"TRIANGULO: {triangulo.ToString("F3", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"CIRCULO: {circulo.ToString("F3", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"TRAPEZIO: {trapezio.ToString("F3", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"QUADRADO: {quadrado.ToString("F3", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"RETANGULO: {retangulo.ToString("F3", CultureInfo.InvariantCulture)}");
            }




        }
    }
}
