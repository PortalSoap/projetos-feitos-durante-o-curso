using System;

namespace Try_Catch_Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            try // O bloco "try" deve ser aplicado onde possívelmente haverá um erro por parte do usuário.
            {
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());

                c = a / b;
                Console.WriteLine("Result: " + c);
            }
            catch (DivideByZeroException) // O catch será o resultado (o que deverá ser feito) caso haja exceção. Há vários tipos.
            {
                Console.WriteLine("Divide by 0 is not alowed!");
            }
            catch(Exception x) // Caso seja do tipo de uma superclasse, deverá ser criada uma váriavel para chamar os métodos, e então uma mensagem padrão referente ao tipo de exceção será exibida.
            {
                Console.WriteLine("Error! " + x.Message);
            }
        }
    }
}
