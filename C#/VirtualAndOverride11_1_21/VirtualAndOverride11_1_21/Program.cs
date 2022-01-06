using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualAndOverride11_1_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Calisan calisan = new Calisan();
            calisan.Ad = "Mıstık";
            calisan.Soyad = "mustafa";
            Muhendis muhendis = new Muhendis();
            muhendis.Ad="Mustafa";
            muhendis.Soyad = "İnan";
            Console.WriteLine(calisan.ToString() + "\n" + "Maaş: " + calisan.MaasHesapla() + "\n" + muhendis.ToString() + "\n" + "Maaş: " + muhendis.MaasHesapla());
            Console.ReadLine();
        }
    }
}
