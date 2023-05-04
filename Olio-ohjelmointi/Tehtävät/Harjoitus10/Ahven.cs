using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus10
{
    internal class Kala : Elain, ICanSwim
    {
        public int SwimSpeed { get; set;  }
        public string sound { get; set; }   

        public Kala(string _name, int _speed, string _sound) 
        {
            Name = _name;
            SwimSpeed = _speed;
            sound = _sound; 
        }

        public override void MakeAsound()
        {
            Console.WriteLine(sound);
        }

        public void swim()
        {
            Console.WriteLine("Kala {0} ui nopeudella {1}", Name, SwimSpeed );
        }
    }
}
