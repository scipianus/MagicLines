using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicLines
{
    class Persoana
    {
        public int scor;
        public string nume;

        public Persoana()
        {
            scor = 0;
            nume = "";
        }

        public Persoana(int sscor, string nnume)
        {
            scor = sscor;
            nume = nnume;
        }
    }
}
