using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinifNesneleriniAnlamak1_2_1_21
{
    class Kutu
    {
        //field(alan)
        public int yukseklik;
        public int genislik;
        private int derinlik;

       public Kutu()
       {
           Console.WriteLine("Kutu sınıfı Nesne Örneği Kuruldu");
            Program P = new Program();
       }
        //construtor overload
        public Kutu(int yukseklik,int genislik,int derinlik)
        {
            this.yukseklik = yukseklik;
            this.genislik = genislik;
            this.derinlik = derinlik;
        }

    }
}
