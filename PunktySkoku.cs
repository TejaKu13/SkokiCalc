using System;
using System.Collections.Generic;
using System.Text;

namespace SkokiCalc
{
    public class PunktySkoku
    {
        public double punktK;
        public double punktyBazowe;
        public double punktyZaMetr;

        public PunktySkoku(double kPoint)
        {
            punktK = kPoint;
            Console.WriteLine("Punkt K skoczni:"+punktK);
        }

        public double ObliczPunkty(double meterPoints,double kPoint,double basePoints)
        {
            punktK = kPoint;
            punktyBazowe = basePoints;
            punktyZaMetr = meterPoints;
            double meters;
            double jumpMeters;
            double jumpPoints;
            Console.WriteLine("Podaj odległość:");

            Console.WriteLine("punkty za oddany skok:"+jumpPoints);
            return 0;
        }

    }
}
