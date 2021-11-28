using System;
using System.Text;
using System.Globalization;

namespace Exercicio_sem_Interface.Entities
{
    class Rent
    {
        public string CarModel { get; set; }
        public DateTime PickupDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        public Rent()
        {
        }

        public Rent(string carModel, DateTime pickupDate,
            DateTime returnDate, double pricePerHour, double pricePerDay)
        {
            CarModel = carModel;
            PickupDate = pickupDate;
            ReturnDate = returnDate;
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
        }

        public double BasePayment()
        {
            TimeSpan duration =  ReturnDate.Subtract(PickupDate);
            int hours = duration.Hours;
            int days = duration.Days;
            if(duration.Days < 1 && duration.Hours <= 12)
            {
                if(duration.Minutes > 0)
                {
                    hours++;
                    
                }
                return hours * PricePerHour;
            }
            else
            {
                if(duration.Hours > 0)
                {
                    days++;
                }
                return days * PricePerDay;
            }
        }

        public double TaxPayment()
        {
            double basePayment = BasePayment();
            if(basePayment <= 100)
            {
                return 0.2 * basePayment;
            }
            else
            {
                return 0.15 * basePayment;
            }
        }

        public double TotalPayment()
        {
            return BasePayment() + TaxPayment();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("INVOICE:");
            sb.AppendLine("Basic payment: " + BasePayment().ToString("F2", CultureInfo.InvariantCulture));
            sb.AppendLine("Tax: " + TaxPayment().ToString("F2", CultureInfo.InvariantCulture));
            sb.AppendLine("Total payment: " + TotalPayment().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
