using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IleriSeviyeSinifKullanimi1_11_1_21
{
    class Program
    {
        static void Main(string[] args)
        {

            Liste<string> liste = new Liste<string>();
            liste.Add("efe");
            liste.Add("seymen");
            liste.GetT();
            Liste<decimal> liste1 = new Liste<decimal>();

            Console.ReadLine();
        }
    }
    class Liste
    {

    }
    class Liste<T> //calasoverloading
    {
        public Liste()
        {
            Console.WriteLine(typeof(T));
        }
        List<T> liste = new List<T>();
         public void Add(T t)
         {
            liste.Add(t);
         }

        public void GetT()
        {
            foreach (var t in liste)
            {
                Console.WriteLine("t: " + t);
            }
        }

    }
    
}
