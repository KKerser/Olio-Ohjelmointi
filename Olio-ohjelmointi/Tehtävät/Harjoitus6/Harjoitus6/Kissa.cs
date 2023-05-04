using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus6
{
    internal class Kissa : Eläimet
    {
        private static int instanssit = 0;
        public Kissa()
        {
            instanssit++;
        }
        public static new void KuinkaMonta()
        {
            Console.WriteLine("Koiria luotu " + instanssit);
        }
        public override void Ääni()
        {
            Console.WriteLine("Meow"); 
        }
    }
}
