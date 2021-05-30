using System;

namespace Teste_de_Funçoes.Entities
{
    class Dice
    {
        public int MaxValue { get; set; }
        public int MinValue { get; set; }

        public Dice()
        {
        }

        public Dice(int minValue, int maxValue)
        {
            MaxValue = maxValue;
            MinValue = minValue;

            if(MinValue < 0 || MinValue > 99)
            {
                MinValue = 0;
            }
            
            if(MaxValue > 100)
            {
                MaxValue = 100;
            }
        }

        public int Roll()
        {
            Random diceRoll = new Random();
            int result = diceRoll.Next(MinValue, MaxValue);

            return result;
        }
    }
}
