using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionveFunc_15_1_21
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //ACTİON

            //geriye değer döndürmeyen void metotlar için kullanılır
            //delegatin geriye değer döndürmeyen .net framework sınıfı versiyonudur
            Action<string, string> action = new Action<string, string>(KullaniciBilgisi);
            action("ozi", "üstündağ");

            //fUNC
            //geriye değer dönebilen action vers,yonudur ya da delegatee versiyonudur.
            Func<DateTime, double> func = new Func<DateTime, double>(KullaniciAge);
            func(new DateTime(1982, 11, 1));

           
        }
        static void KullaniciBilgisi(string ad, string soyad)
        {
            Console.WriteLine("ad:" + ad);
            Console.WriteLine("soyad:" + soyad);
        }
        static double KullaniciAge(DateTime age)
        {
            return (DateTime.Now - age).TotalDays;
        }

    }
    
    
}
