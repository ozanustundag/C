using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Kalitim_5_1_21
{
    class IkiBoyut
    {
        public int Yukseklik { get; set; }
        public int Genislik { get; set; }
        public void Goster()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Genislik: " + Genislik);
            stringBuilder.Append(Environment.NewLine);
            stringBuilder.Append("Yukseklik: " + Yukseklik);
            Console.WriteLine(stringBuilder.ToString());
        }
    }
}
