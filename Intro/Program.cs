using System;

namespace Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarBugun>dolarDun)
            {
                Console.WriteLine("Dolar arttı.");
            }
            else if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Dolar düştü.");
            }
            else
            {
                Console.WriteLine("Dolarda değişme gözlenmedi.");
            }
        }
    }
}
