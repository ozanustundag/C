using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Arayuz_Nedir5_1_21
{
    interface IKullanici
    {
        void Ekle(string kullaniciAd, string email, string sifre);
        void Guncelle(int kullaniciId, string kullalaniciAd, string email, string sifre);
        void Sil(int kullaniciId);
        KullaniciInfo Getir(int kullaniciId);
        List<KullaniciInfo> KullanicilariGetir();
        void Aktif(int kullaniciId);
        void Pasif(int KullaniciId);
        bool Giris(string email, string sifre);
    }
}
