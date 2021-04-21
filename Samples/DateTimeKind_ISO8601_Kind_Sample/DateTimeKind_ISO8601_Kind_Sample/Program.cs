using System;

namespace DateTimeKind_ISO8601_Kind_Sample {
    class Program {
        static void Main(string[] args) {

            // Função para formatar a data para o formato local.
            DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
            Console.WriteLine(d1);
            Console.WriteLine();

            // Função para formatar a data para o formato universal (utc).
            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
            Console.WriteLine(d2);
            Console.WriteLine();

            // Exemplo de data sem formatação.
            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);
            Console.WriteLine(d3);
            Console.WriteLine();

            // Exemplos do professor.

            // d1.
            Console.WriteLine("d1: " + d1);
            Console.WriteLine("--------------------");
            Console.WriteLine("d1 Kind: " + d1.Kind);
            Console.WriteLine("--------------------");
            Console.WriteLine("d1 to Local: " + d1.ToLocalTime());
            Console.WriteLine("--------------------");
            Console.WriteLine("d1 to Utc: " + d1.ToUniversalTime());
            Console.WriteLine();

            // d2.
            Console.WriteLine("d2: " + d2);
            Console.WriteLine("--------------------");
            Console.WriteLine("d2 Kind: " + d2.Kind);
            Console.WriteLine("--------------------");
            Console.WriteLine("d2 to Local: " + d2.ToLocalTime());
            Console.WriteLine("--------------------");
            Console.WriteLine("d2 to Utc: " + d2.ToUniversalTime());
            Console.WriteLine();

            // d3.
            Console.WriteLine("d3: " + d3);
            Console.WriteLine("--------------------");
            Console.WriteLine("d3 Kind: " + d3.Kind);
            Console.WriteLine("--------------------");
            Console.WriteLine("d3 to Local: " + d3.ToLocalTime());
            Console.WriteLine("--------------------");
            Console.WriteLine("d3 to Utc: " + d3.ToUniversalTime());
            Console.WriteLine("--------------------");
            Console.WriteLine();

            // ISO 8601.
            // OBS: O formato ISO 8601 já é adaptado para a data local do computado ao qual está sendo utilizado o programa.

            // Formato padrão.
            DateTime d4 = DateTime.Parse("2000-08-15 13:05:58");
            Console.WriteLine(d4);
            Console.WriteLine("--------------------");

            // Formato ISO 8601.
            DateTime d5 = DateTime.Parse("2000-08-15T13:05:58Z");
            Console.WriteLine(d5);
            Console.WriteLine("--------------------");

            // Exemplos do professor.

            // d4.
            Console.WriteLine("d4: " + d4);
            Console.WriteLine("--------------------");
            Console.WriteLine("d4 Kind: " + d4.Kind);
            Console.WriteLine("--------------------");
            Console.WriteLine("d4 to Local: " + d4.ToLocalTime());
            Console.WriteLine("--------------------");
            Console.WriteLine("d4 to Utc: " + d4.ToUniversalTime());
            Console.WriteLine();

            // d5.
            Console.WriteLine("d5: " + d5);
            Console.WriteLine("--------------------");
            Console.WriteLine("d5 Kind: " + d5.Kind);
            Console.WriteLine("--------------------");
            Console.WriteLine("d5 to Local: " + d5.ToLocalTime());
            Console.WriteLine("--------------------");
            Console.WriteLine("d5 to Utc: " + d5.ToUniversalTime());
            Console.WriteLine();

            // Máscara de formatação para ISO 8601.
            Console.WriteLine(d5.ToString("yyyy-MM-ddTHH:mm:ssZ")); // Cuidado! Pode dar problema.
            Console.WriteLine(d5.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ")); // Garanta primeiro que o horário esteja formatado para horário universal.
        }
    }
}
