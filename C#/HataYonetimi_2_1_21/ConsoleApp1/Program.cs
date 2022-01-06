using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hata Yönetimi(Exception Handling)
            /* 
             try
             ...
             catch
             ... 
             */
            int a=5,b=0;
            //try
            //{
            //    //Hata oluşabilecek kodların yazıldığı alan.
            //    Console.WriteLine(a / b);
            //}
            //catch
            //{
            //    //Hata oluştuğunda yapılıcak işlerin yazıldığı alan
            //    Console.WriteLine("Hata Oluştu");
            //}


            //try
            //{
            //    int[] dizi = new int[2];
            //   // dizi[3] = 5;
            //   // Console.WriteLine(a / b);
            //}
            //catch (IndexOutOfRangeException ex)
            //{

            //    Console.WriteLine("Hata(IndexOutOfRangeException):" +ex.Message);
            //}
            //catch(DivideByZeroException ex)
            //{
            //    Console.WriteLine("Hata(DıvıdebyZeroException):" + ex.Message);
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine("Hata:" + ex.Message);
            //}

            //SqlConnection conn = new SqlConnection();
            //try
            //{
            //    //OleDbConnection;
            //    //Oracle for .NET
            //    //ODB.NET
            //    Console.WriteLine(a / b);
            //    //ORACLECONNECTİON
            //}
            //catch (Exception ex)
            //{
            //    return;
            //   // Console.WriteLine("catch");

            //}
            //finally
            //{
            //    Console.WriteLine("Finally");
            //    //conn.Close();
            //    //Hata olsa da olamasa da çalışır.
            //    Console.ReadLine();
            //}
            //Console.WriteLine("AlanDışı");

            var x = IsYap();
            Console.WriteLine("x= {0}", x);


            Console.ReadLine();
        }
        public static int IsYap()
        {
            try
            {
                return 5;
            }

            finally
            {
                Console.WriteLine("Finally");
                //finally çalışmadan return olmaz
            }
        }
    }
}
