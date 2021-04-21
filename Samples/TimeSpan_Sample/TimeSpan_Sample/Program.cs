using System;

namespace TimeSpan_Sample {
    class Program {
        static void Main(string[] args) {

            // Função para instanciar e imprimir o TimeSpan em seu formato padrão.
            TimeSpan t1 = new TimeSpan(0, 1, 30);
            Console.WriteLine(t1);
            Console.WriteLine("--------");

            // Função para contar ticks de 0 até o valor defnido.
            // OBS: Quanto utilizado em DateTime, os ticks são contados desde o primeiro dia do ano
            // até o momento atual. O TimeSpan representa uma duração.
            Console.WriteLine(t1.Ticks);
            Console.WriteLine("--------");

            // Utilizando um construtor sem nenhum argumento.
            TimeSpan t2 = new TimeSpan();
            Console.WriteLine(t2);
            Console.WriteLine("--------");

            // Utilizando ticks para determinar um momento.
            // OBS: Como o tipo que armazena os ticks é Long, então se deve colocar um "L" após ter terminado de 
            // inserir o número desejado de ticks.
            TimeSpan t3 = new TimeSpan(900000000L);
            Console.WriteLine(t3);
            Console.WriteLine("--------");

            // Utilizando um construtor com 3 argumentos (hora, minuto e segundo).
            TimeSpan t4 = new TimeSpan(2, 11, 21);
            Console.WriteLine(t4);
            Console.WriteLine("--------");

            // Utilizando um construtor de 4 argumentos (dia, hora, minuto e segundo)
            TimeSpan t5 = new TimeSpan(1, 2, 11, 21);
            Console.WriteLine(t5);
            Console.WriteLine("--------");

            // Utilizando um construtor de 5 argumentos (dia, hora, minuto, segundo e mílisegundo)
            TimeSpan t6 = new TimeSpan(1, 2, 11, 21, 321);
            Console.WriteLine(t6);
            Console.WriteLine("--------");

            // Função para conversão em duração.
            TimeSpan t7 = TimeSpan.FromDays(1.5); // 1.5 dias é igual a um dia e meio, então, ficaria 1 dia e 12 horas.
            Console.WriteLine(t7);
            Console.WriteLine("--------");

            TimeSpan t8 = TimeSpan.FromHours(1.5); // 1.5 horas é igual a uma hora e meia, então, ficaria 1 hora e 30 minutos.
            Console.WriteLine(t8);
            Console.WriteLine("--------");

            TimeSpan t9 = TimeSpan.FromMinutes(1.5); // 1.5 minutos é igual a um minuto e meio, então, ficaria 1 minuto e 30 segundos.
            Console.WriteLine(t9);
            Console.WriteLine("--------");

            TimeSpan t10 = TimeSpan.FromSeconds(1.5); // 1.5 segundos é igual a um segundo e meio, então ficaria 1 segundo e 5000000 mílissegundos.
            Console.WriteLine(t10);
            Console.WriteLine("--------");

            TimeSpan t11 = TimeSpan.FromMilliseconds(1.5); // 1.5 mílissegundos é igual meio mílissegundo, então ficaria 15000 mílissegundos.
            Console.WriteLine(t11);
            Console.WriteLine("--------");

            TimeSpan t12 = TimeSpan.FromTicks(900000000L);// Os ticks são a unidade de contagem mais baixa do TimeSpan, então não se pode usar um decimal. Nesse caso, irá ser convertido para uma duração.
            Console.WriteLine(t12);
            Console.WriteLine("--------");
        }
    }
}
