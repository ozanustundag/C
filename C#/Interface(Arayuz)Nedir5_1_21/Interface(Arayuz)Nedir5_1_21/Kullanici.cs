using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Arayuz_Nedir5_1_21
{
    class Kullanici :Program, IKullanici,IYetki
    {
        public int YetkiId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int KullaniciId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Aktif(int kullaniciId)
        {
            throw new NotImplementedException();
        }

        public void Ata(int kullaniciId, int yetkiId)
        {
            throw new NotImplementedException();
        }

        public void Ekle(string kullaniciAd, string email, string sifre)
        {
            throw new NotImplementedException();
        }

        public KullaniciInfo Getir(int kullaniciId)
        {
            KullaniciInfo inf = new KullaniciInfo();
            inf.Ad = "ozi";
            inf.ID = 456;
            inf.Soyad = "üstü";
            return inf;
        }

        public bool Giris(string email, string sifre)
        {
            throw new NotImplementedException();
        }

        public void Guncelle(int kullaniciId, string kullalaniciAd, string email, string sifre)
        {
            throw new NotImplementedException();
        }

        public void Kaldir(int kullaniciId, int yetkiId)
        {
            throw new NotImplementedException();
        }

        public List<KullaniciInfo> KullanicilariGetir()
        {
            List<KullaniciInfo> Kullanicilar = new List<KullaniciInfo>();
            Kullanicilar.Add(new KullaniciInfo() { Ad = "ozi", ID = 5, Soyad = "zaa" });
            Kullanicilar.Add(new KullaniciInfo() { Ad = "musti", ID = 2, Soyad = "xxxx" });
            return Kullanicilar;
        }

        public void Pasif(int KullaniciId)
        {
            throw new NotImplementedException();
        }

        public void Sil(int kullaniciId)
        {
            throw new NotImplementedException();
        }
        public void Sil(string email)
        {

        }
    }
}
