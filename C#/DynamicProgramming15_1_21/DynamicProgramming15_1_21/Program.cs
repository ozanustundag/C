using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming15_1_21
{
    class Program
    {
        static void Main(string[] args)
        {
            //dinamik programlama

            //dynamic a = 5;
            //Console.WriteLine(a);
            //a = "sa";
            //Console.WriteLine(a);

            //dynamic insan = new ExpandoObject();
            //insan.ad = "ozi";
            //insan.soyad = "reis";
            //Console.WriteLine(insan.ad + insan.soyad);


            //dynamic kisi = new ExpandoObject();
            //kisi.ad = "mustafa";
            //kisi.soyad = "inan";
            //kisi.AdGoster = new Action<string>((a) =>
            //  {
            //      Console.WriteLine(kisi.ad + kisi.soyad+a);
            //  });
            //kisi.AdGoster("fadsfasd");
            //kisi.TekrarEt = new Func<string,string>(a =>
            //  {
            //      return a;
            //  });

            //string s = kisi.TekrarEt("tekrarlandi");
            //Console.WriteLine(s);


            

            foreach (dynamic user in GetList())
            {
                Console.WriteLine("{0} {1}", user.Ad, user.Soyad);
            }
            Console.ReadLine();
        }

        private static IEnumerable<dynamic> GetList()
        {
            var users = new List<User>
            {
                new User(){ ID=1,FirstName="ozan",LastName="üstündağ"},
                new User(){ID=2,FirstName="selami",LastName="Sucuk"}
            };
            return from k in users
                   select new{ Ad = k.FirstName, Soyad = k.LastName};
            
        }
    }
    class User
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
