using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate11_1_21
{
    class Program
    {
        static void Main(string[] args)
        {
            //delegate

            //Hesap hesap = Topla;
            //Console.WriteLine("TOPLA: " + hesap(1, 2));
            //hesap = Carp;
            //Console.WriteLine("Çarp: " + hesap(4, 2));

            Hesap hesap = new Hesap(Topla);
            Console.WriteLine("TOPLA: " + hesap(1, 2));
            hesap = new Hesap(Carp);
            Console.WriteLine("Çarp: " + hesap.Invoke(2,2));


            Console.ReadLine();
        }
         delegate int Hesap(int a, int b);

        static int Topla(int x,int y)
        {
            return x + y;
        }
        static int Cıkart(int x,int y)
        {
            return x - y;
        }
        static int Carp(int x,int y)
        {
            return x * y;
        }
        static int Bol(int x,int y)
        {
            if (x > 0 && y > 0)
            {
                return x / y;
            }
            else
                return 0;
        }
    }
}
