using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IleriSinifKullanimi3_11_1_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Islemler<double> islemler = new Islemler<double>();
           Console.WriteLine(islemler.IslemYap(5, -2));
            Console.ReadLine();
        }
    }
    class Islemler<T>
    {
        public T IslemYap(T guccukT,int param)
        {
            if (param>0)
            {
                return guccukT;
            }
            else
            {
                return default(T);
            }
        }
    }
}
