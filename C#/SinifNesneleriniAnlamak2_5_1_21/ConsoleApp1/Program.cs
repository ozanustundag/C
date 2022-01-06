using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Kutu K = new Kutu();
            // K.SetUzunluk(-100);
            // Console.WriteLine(K.GetUzunluk());
            K.Genislik = -10;
            Console.WriteLine(K.Genislik);
            Console.ReadLine();
        }
    }
}
