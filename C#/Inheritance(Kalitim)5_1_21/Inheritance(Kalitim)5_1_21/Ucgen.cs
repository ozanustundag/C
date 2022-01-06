using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Kalitim_5_1_21
{
    class Ucgen:IkiBoyut
    {
        public string Stil { get; set; }
        public void StilGoster()
        {
            Console.WriteLine("Stil: " + Stil);
        }
        public int Alan()
        {
            return Genislik * Yukseklik/2;
        }
    }
}
