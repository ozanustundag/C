using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IleriSeviyeSinifKullanimi2_11_1_21
{
    class Program
    {
       static int[] diizi = new int[5];
        static void Main(string[] args)
        {
            diizi[0] = 5;
          //  diizi = new int[2];
            Console.WriteLine(diizi[0]);
            MyListz<string> myListz = new MyListz<string>();
            myListz.Ekle("ozi");
            Console.WriteLine("Eleman SAYİ= " + myListz.ElementSayi);
            Console.ReadLine();
        }
        
    }
    class MyListz<T>
    {
         T[] dizi;
        public void Ekle(T deger)
        {
            try
            {
                T[] geciciDizi = new T[dizi.Length];
                geciciDizi = dizi;
                dizi = new T[geciciDizi.Length + 1];
                for (int i = 0; i < geciciDizi.Length; i++)
                {
                    dizi[i] = geciciDizi[i];
                }
                dizi[dizi.Length - 1] = deger;
            }
            catch 
            {

                dizi = new T[1];
                dizi[0] = deger;
            }
           
        }
        public int ElementSayi
        {
            get { return dizi.Length; }
        }
    }
}
