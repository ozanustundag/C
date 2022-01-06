using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods1_15_21
{
    static class MyExtensionMethods
    {
        public static void ExtensionObjcet(this object a)
        {
            Console.WriteLine("genişleme metodu");
        }
/// <summary>
/// cool bir metod bu
/// </summary>
/// <param name="a"></param>
/// <returns></returns>
        public static int İntGenisletme(this int a)
        {
            return a * a;
        }

        public static void  ShowItems(this System.Collections.IEnumerable iterator)
        {
            foreach (var item in iterator)
            {
                Console
                    .WriteLine(item);
            }
        }

    }
}
