using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractObjects11_1_21
{
    class Program
    {
        static void Main(string[] args)
        {
            //abstract class
            Isci isci = new Isci();
            Muhendis muhendis = new Muhendis();
            isci.Ad = "ozi";
            isci.Soyad = "reis";
            muhendis.Ad = "Mustafa";
            muhendis.Soyad = "İnan";
            isci.GetFullName();
            Console.WriteLine("Maaş: " + isci.GetSalary());
            muhendis.GetFullName();
            Console.WriteLine("Maaş: " + muhendis.GetSalary());
            Console.ReadLine();
        }
    }
}
