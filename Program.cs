using System;

namespace SkokiCalc
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj położenie punktu K skoczni - od 20 m do 210 m:");
            double punktK = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj ilość punktów za metr - od 1.2 do 4.8:");
            double punkty = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wartość bazową - 120 punktów dla skoczni mamuciej lub 60 punktów dla pozostałych:");
            double podstawa = double.Parse(Console.ReadLine());
            PunktySkoku nowaSkocznia = new PunktySkoku(punktK);
            nowaSkocznia.ObliczPunkty(punkty, punktK, podstawa);
        }
    }
}
