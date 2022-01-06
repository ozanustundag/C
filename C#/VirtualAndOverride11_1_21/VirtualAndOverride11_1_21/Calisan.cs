using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualAndOverride11_1_21
{
    class Calisan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
       
        public virtual double MaasHesapla()
        {
            return 1300;
        }
        public override string ToString()
        {
            //return base.ToString();
            return this.Ad + " " + this.Soyad;
        }
    }
}
