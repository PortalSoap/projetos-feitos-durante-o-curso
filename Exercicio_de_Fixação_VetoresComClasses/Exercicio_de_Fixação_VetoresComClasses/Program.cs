using System;

namespace Exercicio_de_Fixação_VetoresComClasses {
    class Program {
        static void Main(string[] args) {
            // Número de quartos para alugarr
            Console.Write("How many rooms will be rented? ");
            int rented_rooms = int.Parse(Console.ReadLine());
                        
            // Inicialização 
            Rent[] rooms = new Rent[10];
            rooms[0] = null;
            rooms[1] = null;
            rooms[2] = null;
            rooms[3] = null;
            rooms[4] = null;
            rooms[5] = null;
            rooms[6] = null;
            rooms[7] = null;
            rooms[8] = null;
            rooms[9] = null;

            for (int i = 0; i < rented_rooms; i++) {
                Console.WriteLine("Rent #" + (i + 1));
                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());

                rooms[room] = new Rent(name, email, room);
            }

            for(int i = 0; i < 10; i++) {
                if(rooms[i] != null) {
                    Console.WriteLine(rooms[i]);
                }
            }

        }
    }
}
