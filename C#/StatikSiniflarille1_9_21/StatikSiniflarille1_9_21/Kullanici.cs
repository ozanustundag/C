using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatikSiniflarille1_9_21
{
    class Kullanici
    {
         public static  int Id { get; set; }
        public int PrivateId { get; set; }
        public string Ad { get; set; }
        public Kullanici()
        {
            Id += 1;
            PrivateId = Id;
        }
    }
}
