using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods1_15_21
{
    class Program
    {
        static void Main(string[] args)
        {
            //extension methods

            Object obj1 = new Program();
            obj1.ExtensionObjcet();
           
            int x = 5;
            Console.WriteLine(x.İntGenisletme());

            List<string> ozi = new List<string>();
            ozi.Add("afds");
            ozi
                .Add("fadsf");
            ozi.ShowItems();

            Console.ReadLine();
        }
    }
}
