using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Kalitim_5_1_21
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inheritance
            //C c = new C();
            //c.PropA = 1;
            //c.PropB = 1;
            //c.PropC = 1;
            Ucgen ucgen = new Ucgen();
            ucgen.Genislik=5;
            ucgen.Yukseklik = 2;
            ucgen.Stil = "Eşkenar";
            ucgen.Goster();
            ucgen.StilGoster();
            Console.WriteLine("Alan: "+ucgen.Alan());
            Console.ReadLine();

        }
    }
    class A //Base Sınıf
    {
        public int PropA { get; set; }
    }
    class B:A   //Türetilmiş derived sınıf
    {
        public int PropB { get; set; }
    }
    class C:B
    {
        public int PropC { get; set; }
    }
}
