using System.Globalization;

namespace Exercicio_de_Fixação_Manipulação_Arquivos.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Value { get; private set; }
        public int Quantity { get; set; }

        public Product()
        {
        }

        public Product(string name, double value, int quantity)
        {
            Name = name;
            Value = value;
            Quantity = quantity;
        }

        public double Total()
        {
            return Quantity * Value;
        }

        public override string ToString()
        {
            return Name
                + ","
                + Total().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
