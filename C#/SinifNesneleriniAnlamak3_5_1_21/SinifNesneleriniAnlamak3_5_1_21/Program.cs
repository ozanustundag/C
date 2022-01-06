using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinifNesneleriniAnlamak3_5_1_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();
            account.GetAccount(3);
            Console.WriteLine(account.GetAccount(3));
            Console.ReadLine();
        }
    }
}
