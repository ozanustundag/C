using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotlariAnlamak1_2_1_21
{
    class Program
    {
        static void Main(string[] args)
        {
            //Metotlar
            //Yaz("merhaba");
            //Yaz(Topla(1, 3).ToString());
            //var result = Topla(0, -1);
            //Yaz(result.ToString());
            //Yaz("sa");
            //Bosluk(0);           
            //Yaz("as");
            //Beklet();
            //Console.WriteLine( GetAccountName(5));

            Yaz(İsValid("ozanustundag@gmail.com").ToString());
            Beklet();
            

        }
        static void Beklet()
        {
            Console.ReadLine();
        }
        static void Yaz(string metin)
        {
            Console.Write(metin);
        }
        static int Topla(int a,int b)
        {
            return a + b;
        }
        //static void Bosluk()
        //{
        //    Console.Write(Environment.NewLine);
        //}
        static void Bosluk(int boslukSayisi)
        {
            for (int i = 0; i < boslukSayisi; i++)
            {
                Console.WriteLine(Environment.NewLine);
            }
        }
        static string GetAccountName(int accountID)
        {
            string accountName = string.Empty;
            switch (accountID)
            {
                case 1:
                    accountName = "Ozan";
                    break;
                case 2:
                    accountName = "Mahmut";
                    break;
                default:
                    accountName = "bilemedik kardeş";
                    break;
            }
            return accountName;
        }
        static bool İsValid(string email)
        {
            bool isValid = default(bool);
            if (email.Contains("@"))
            {
                isValid = true;
            }
            return isValid;
        }
    }
}
