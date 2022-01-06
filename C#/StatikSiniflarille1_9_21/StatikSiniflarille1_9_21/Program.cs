using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatikSiniflarille1_9_21
{
    class Program
    {
        static void Main(string[] args)
        {

            //Encrypition enc = new Encrypition();
            //enc.Decryption("dfghjkl");
            //enc.Encryption("fghjklş");

            Encrypition.Decryption("dfghj"); //static yaptığımız için nesne örneği oluşturmadan erişebildik
            Encrypition.Encryption("ghjkl");
            Console.WriteLine(Encrypition.Decryption("fghj"));
            Console.WriteLine(Encrypition.Encryption("fghj"));


            Kullanici k1 = new Kullanici();
            Kullanici k2 = new Kullanici();
            Kullanici k3 = new Kullanici();
            Kullanici k4 = new Kullanici();
            Kullanici k5 = new Kullanici();
            Console.WriteLine(Kullanici.Id);
            Console.WriteLine(Kullanici.Id);




            Console.ReadLine();

            
        }
    }
}
