using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjotus1
{
    internal class Ajoneuvo
    {
        public string Nimi { get; set; }
        public int Nopeus { get; set; }
        public int Renkaat { get; set; }
        //kaikki muuttujat

        public Ajoneuvo(string _nimi, int _nopeus, int _renkaat)
        {
            Nimi = _nimi;
            Nopeus = _nopeus;
            Renkaat = _renkaat;
        }
        //konstruktori
        public string TulostaData()
        {
            string AutonTiedot = "nimi: " + Nimi + ". nopeus: " + Nopeus.ToString() + ". Renkaat: " + Renkaat.ToString();

            return AutonTiedot;
        }

        //toiminnot eli metodit
    }
}
