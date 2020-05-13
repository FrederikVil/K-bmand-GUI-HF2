using System;
using System.Collections.Generic;
using System.Text;

namespace Købmand
{
    public class By
    {
        public List<Varer> ByVarer { get; set; }

        public Varer SelectedItems { get; set; }

        public By(string navn)
        {
            Navn = navn;
            Varer korn = new Varer("Korn", Rand.Range(1, 16));
            Varer halm = new Varer("Halm", Rand.Range(1, 21));
            Varer mælk = new Varer("Mælk", Rand.Range(1, 11));
            Varer majs = new Varer("Majs", Rand.Range(1, 21));
            Varer agurk = new Varer("agurk", Rand.Range(1, 11));
            ByVarer = new List<Varer>();
            ByVarer.Add(korn); 
            ByVarer.Add(halm);
            ByVarer.Add(mælk);
            ByVarer.Add(majs);
            ByVarer.Add(agurk);
        }

        public string Navn { get; set; }

    }
}
