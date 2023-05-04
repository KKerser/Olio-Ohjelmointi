using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus10
{
    class Varis : Elain, ICanFly
    {
        public float WingSize {get; set; }

        public Varis(string _Name, float _wingsize)
        { 
            Name = _Name;
            WingSize = _wingsize;
        }
        

        public void Fly()
        {
            Console.WriteLine("{0} lentää. Siipien koko on {1}", Name, WingSize);
        }

        public override void MakeAsound()
        {
            Console.WriteLine("Kakaaw Kakaaw");
        }
    }


}
