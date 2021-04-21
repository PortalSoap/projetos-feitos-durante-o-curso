using System;
using System.Globalization;

namespace DateTime_Sample {
    class Program {
        static void Main(string[] args) {


            // Função que retorna a data atual do computador. Não guarda o valor, mas vai atualizando para sempre 
            // guardar o "agora". Note que o DateTime é um tipo, assim como double, char e string.
            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1);
            Console.WriteLine("------------------");
            // Função que no lugar de inserir o formato padrão de hora (hora:minuto:segundo), imprime os ticks.
            // OBS: Ele exbie os ticks que se foram desde o primeiro dia desse ano (as 0 horas), até o momento atual.
            Console.WriteLine(d1.Ticks);
            Console.WriteLine("------------------");

            // Construtor que permite defnir uma data (No exemplo, utilizei: YYYY/MM/D).
            // OBS: A hora não vai ser oculta, apenas vai ser defnida automáticamente com 0.
            DateTime d2 = new DateTime(2021, 03, 16);
            Console.WriteLine(d2);
            Console.WriteLine("------------------");

            // Construtor que além de permitir inserir data, também permite inserir hora
            // (No exemplo, utilizei: YYYY/MM/D HH:MM:SS).
            // OBS: Também é possível inserir mílisegundo, apenas colocando uma simples vírgula após o segundo, mas não será exibido,
            // então será necessário utilizar uma função de formatação.
            DateTime d3 = new DateTime(2021, 03, 16, 21, 38, 38);
            Console.WriteLine(d3);
            Console.WriteLine("------------------");

            // Função para obter a data de hoje, mas com a hora zerada.
            DateTime d4 = DateTime.Today;
            Console.WriteLine(d4);
            Console.WriteLine("------------------");

            // Função para obter o horário e data com base no meridiano de Greenwich.
            DateTime d5 = DateTime.UtcNow;
            Console.WriteLine(d5);
            Console.WriteLine("------------------");

            // Função para conversão de string para DateTime com data.
            // OBS: O VisualStudio já é preparado para armazenar datas separadas por "-" então pode usar sem medo no string, que ele vai 
            // entender o que você está querendo dizer. Também funciona no padrão brasileiro e com "/".
            DateTime d6 = DateTime.Parse("2021-03-16");
            Console.WriteLine(d6);
            Console.WriteLine("------------------");

            // Função para conversão de string para DateTime com data e hora.
            // OBS: Para separar data de hora, basta só colocar o espaço. Para separar a hora do minuto, utilizar ":".
            DateTime d7 = DateTime.Parse("2021-03-16 22:31:13");
            Console.WriteLine(d7);
            Console.WriteLine("------------------");

            // Função para utilizar uma data num formato criado por você.
            // OBS: Basta colocar como você quer organizar a data com dd para dia, MM para mês e yyyy para ano. (chama-se "máscara de formatação")
            // Por fim, colocar um "FormatProvider" que é o formato que você deseja colocar (de algum país por exemplo).
            DateTime d8 = DateTime.ParseExact("16-03-2021", "dd-MM-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(d8);
            Console.WriteLine("------------------");

            // Função para utilizar uma data num formato criado por você, mas agoar com hora também.
            // OBS: Não tem muita coisa de diferente, apenas que para minuto, deve-se usar HH para hora, mm para minuto e ss para segundo.
            // sempre separado por ":" quando for defnir hora.
            DateTime d9 = DateTime.ParseExact("16-03-2021 22:44:38", "dd-MM-yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine(d9);
            Console.WriteLine("------------------");
            
            // Mostrar apenas data.
            // Exemplo experimental, desconsiderar caso já tenha encontrado solução melhor.
            Console.WriteLine(d9.ToString("dd/MM/yyyy")); // Serve para exibir hora também. Basta apenas trocar a máscara de data para hora.
        }
    }
}
