using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Arayuz_Nedir5_1_21
{
    interface IYetki
    {
        int YetkiId { get; set; }
        int KullaniciId { get; set; }
        void Ata(int kullaniciId, int yetkiId);
        void Kaldir(int kullaniciId, int yetkiId);
    }
}
