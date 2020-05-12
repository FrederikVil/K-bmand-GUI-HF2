using System;
using System.Collections.Generic;
using System.Text;

namespace Købmand
{
    public class By
    {
        public List<Varer> ByVarer { get; set; }

        public Varer SelectedCity { get; set; }

        public By(string navn)
        {
            Navn = navn;
            Varer vare = new Varer("Korn", Rand.Range(1, 16));
            ByVarer = new List<Varer>();
            ByVarer.Add(vare); 
        }

        public string Navn { get; set; }

    }
}
