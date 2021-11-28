using System;
using System.Globalization;

using Exercicio_sem_Interface.Entities;

namespace Exercicio_sem_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            string carModel;
            double pricePerHour, pricePerDay;
            DateTime pickupDate, returndate;

            Console.WriteLine("Enter rental data");
            Console.Write("Car model: ");
            carModel = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy - HH:mm): ");
            pickupDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (dd/MM/yyyy - HH:mm): ");
            returndate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Enter price per hour: ");
            pricePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter price per day: ");
            pricePerDay = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Rent r = new Rent(carModel, pickupDate, returndate, pricePerHour, pricePerDay);
            Console.WriteLine(r);
        }
    }
}
