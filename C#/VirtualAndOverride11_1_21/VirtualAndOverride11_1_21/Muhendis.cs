using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualAndOverride11_1_21
{
    class Muhendis:Calisan
    {
        public int tur { get; set; }

        public override double MaasHesapla()
        {
            //return base.MaasHesapla();
            //return 4000;
            return base.MaasHesapla() * 4;
        }
    }
}
