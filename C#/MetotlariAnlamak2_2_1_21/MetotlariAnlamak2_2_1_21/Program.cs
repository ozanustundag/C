using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotlariAnlamak2_2_1_21
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(EnBuyuk(1,2,3,4));
            
            //opsiyonel parametreler
            //isimlendirilmiş parametreler
            KullaniciEkle(
                soyad:"ozi", 
                ad:"baba",
                aktifMi: true);
            Console.ReadLine();
        }
        static void KullaniciEkle(string ad,string soyad,bool cinsiyet=true,bool aktifMi=false)
        {
            Console.WriteLine("Ad: " + ad + "\nSoyad: " + soyad + "\nAktiflik: " + aktifMi+"\nCinsiyet: "+cinsiyet);
        }
        static int Topla(int a,int b)
        {
            return a + b;
        }
        static int Topla(int a,int b,int c)
        {
            return Topla(Topla(a, b), c);
        }
        static double Topla(double a,double b)
        {
            return a+b;
        }
        static int EnBuyuk(int a,int b)
        {
            if (a > b)
                return a;
            return b; 
        }
        static int EnBuyuk(int a,int b,int c)
        {
            return EnBuyuk(EnBuyuk(a, b), c);
        }
        static int EnBuyuk(params int[] sayilar)
        {
            int toplam = 0;
            foreach (var item in sayilar)
            {
                toplam += item;
            }
            return toplam;
        }
        
    }
}
