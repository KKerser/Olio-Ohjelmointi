using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektiScrum
{
    internal class Auto
    {
        public string Nimi { get; set; }
        public int Nopeus { get; set; }
        public int Renkaat { get; set; }

        public Auto(string _nimi , int _nopeus , int _renkaat) 
        {
            Nimi = _nimi;
            Nopeus = _nopeus;
            Renkaat = _renkaat;
        }

        public string TulostaData()
        {
         string AutonTiedot = ("Nimi: " + Nimi + ". Nopeus: " +  Nopeus.ToString() + ". Renkaat " + Renkaat.ToString());
            return AutonTiedot;
        }
    }
}
