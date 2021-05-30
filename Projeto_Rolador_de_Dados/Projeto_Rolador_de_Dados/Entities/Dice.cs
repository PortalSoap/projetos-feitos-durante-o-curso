using System;
using System.Text;

namespace Projeto_Rolador_de_Dados.Entities
{
    class Dice
    {
        public int MinValue { get; set; }
        public int MaxValue { get; set; }
        public RollQuantity RollQuantity { get; set; }

        public int[] Values;

        public Dice()
        {
        }

        public Dice(int maxValue)
        {
            MinValue = 1;
            MaxValue = maxValue + 1;
            // Colocar sempre "+ 1" para que o valor máximo também possa ser rolado.
        }

        public int Roll(RollQuantity rollQuantity)
        {
            Random rd;
            int tempResult, finalResult;
            Values = new int[rollQuantity.Quantity];
            
            finalResult = 0;
            rd = new Random();

            for(int i = 0; i < Values.Length; i++)
            {
                tempResult = rd.Next(MinValue, MaxValue);
                
                Values[i] = tempResult;
                finalResult += tempResult;
            }
            return finalResult;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < Values.Length; i++)
            {
                sb.AppendLine($"Resultado {i + 1}: {Values[i]}");
            }

            return sb.ToString();
        }
    }
}
