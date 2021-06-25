using System.Globalization;

namespace Teste_de_Funçoes.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; protected set; }

        public Employee()
        {
        }

        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        public virtual double Payment()
        {
            return (double)ValuePerHour * Hours;
        }

        public override string ToString()
        {
            return Name
                + " - $ " + Payment().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
