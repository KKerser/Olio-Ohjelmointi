using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus6
{
    internal class Eläimet
    {
        public string nimi { get; set; }

        private static int instanssit = 0;

        public Eläimet()
        {
            instanssit++;
        }
        public static void KuinkaMonta()
        {
            Console.WriteLine("Eläimiä luotu " +  instanssit);
        }

        public virtual void Ääni()
        {

        }
    }
}
