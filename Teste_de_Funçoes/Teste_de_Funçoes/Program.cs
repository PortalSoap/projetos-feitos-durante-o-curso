using System;
using System.Collections.Generic;

namespace Teste_de_Funçoes
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;

            DateTime timeNow, timeOld;
            List<DateTime> dates = new List<DateTime>();

            timeNow = DateTime.Now;
            timeOld = DateTime.Parse(timeNow.ToString());
            dates.Add(timeOld);

            i = 0;
            while(1 < 2)
            {
                if(timeNow != dates[i])
                {
                    Console.WriteLine(timeNow);
                    timeOld = DateTime.Parse(timeNow.ToString());
                    dates.Add(timeOld);
                    i++;
                }
            }
        }
    }
}
