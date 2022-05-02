using System;
using System.Collections.Generic;
using System.Text;

namespace SkokiCalc
{
    public class PunktySkoku
    {
        public double punktK;
        public double punktyZaMetr;

        public PunktySkoku(double meterPoints, double kPoint)
        {
            punktyZaMetr = meterPoints;
            punktK = kPoint;
            Console.WriteLine("Punkt K skoczni:"+punktK+" ,a punkty za metr:"+punktyZaMetr);
        }
        

    }
}
