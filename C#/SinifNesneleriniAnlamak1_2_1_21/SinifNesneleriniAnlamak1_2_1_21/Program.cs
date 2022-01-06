using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinifNesneleriniAnlamak1_2_1_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Kutu k = new Kutu();
            Kutu k1 = new Kutu(4, 3, 2);

            Console.WriteLine(k1.genislik+"+"+k.genislik);
            Console.ReadLine();
        }
        public Program()
        {
            Console.WriteLine("Program sınıfı nesne rneği oluşturuldu");
        }
        
    }
}
