using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatikSiniflarille1_9_21
{
    static class Encrypition // nesne örneği oluştuyrmasını istemediğimz zaman başına static eklememiz yeterli
    {
        //static sınıfların içerisinde kullanacağım paramtrelrinde static olması gerekiyor çünkü sttic olmazsa nesne örneği
        //kurulurken oluşacak o parametrelr ama static olan metodu nesne örneği olmadan lullanabiliyotuz.
        private static int Id;
        public  static string Decryption( string data)
        {
            return data +Id;
        }
        public static string Encryption(string data)
        {
            return data+Id;
        }

        // public Encrypition()
        //{

        //}
        static Encrypition() // bu da structure ama sadece bir kere çalışıyor. o da ilk çağrıldığında sadece.2. kez çağrılınca çalışmaz.
        {
            Id = new Random().Next(100, 250);
        }
    }
}
