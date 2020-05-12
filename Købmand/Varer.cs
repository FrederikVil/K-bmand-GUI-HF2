using System;
using System.Collections.Generic;
using System.Text;

namespace Købmand
{
    public class Varer
    {
        public Varer(string vare, int pris)
        {
            AntalVare = Rand.Range(1, 6);
            VareNavn = vare;
            Pris = pris;
        }

        public string VareNavn { get; set; }

        public int Pris { get; set; }

        public int AntalVare { get; set; }


    }
}
