using System.Globalization;

namespace Exercicio_de_Fixação_Polimorfismo_2.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFee)
            : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice(double customsFee)
        {
            return Price + customsFee;
        }

        public override string PriceTag()
        {
            return Name + " $ " + TotalPrice(CustomsFee).ToString("F2", CultureInfo.InvariantCulture)
                + $" (Customs fee: $ {CustomsFee.ToString("F2", CultureInfo.InvariantCulture)})";
        }
    }
}
