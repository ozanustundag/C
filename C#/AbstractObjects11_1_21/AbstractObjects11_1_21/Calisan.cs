using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractObjects11_1_21
{
     abstract class Calisan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Unvan { get; set; }
        public void GetFullName()
        {
            Console.WriteLine("Ad: " + Ad + "\nSoyad: " + Soyad + "\nÜnvan: " + Unvan);
        }
        public abstract double GetSalary();

    }
}
