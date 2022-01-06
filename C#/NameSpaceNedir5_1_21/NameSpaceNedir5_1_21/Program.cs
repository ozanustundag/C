using System;
using PATA=ProjectA.TeamA; //PATA VE PATB OLARAK İSİMLENDİREKEREK İÇLERİNDEKİ AYNI ADLI SINIFLARA ERİŞEBİLİYOK.
using PATB=ProjectA.TeamB;


namespace NameSpaceNedir5_1_21
{
    class Program
    {
        static void Main(string[] args)
        {
            //NameSpace

            //ProjectA.TeamA.ClassA classA = new ProjectA.TeamA.ClassA();
            //classA.PrintT();
            //ProjectA.TeamA.ClassA.Print();
            Console.ReadLine();

           PATA.ClassA classA = new PATA.ClassA();
        }
    }
}
namespace ProjectA
{
    namespace TeamA
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("ProjectA,TeamA,ClassA,Print()");
            }
            public void PrintT()
            {
                Console.WriteLine("ProjectB,TeamA,ClassA,PrintT()");
            }

        }
    }
    namespace TeamB
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("ProjectA,TeamB,ClassA,Print()");
            }
            public void PrintT()
            {
                Console.WriteLine("ProjectB,TeamA,ClassA,PrintT()");
            }

        }
    }
}
namespace ProjectB
{
    namespace TeamA
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("ProjectB,TeamA,ClassA,Print()");
            }
            public  void PrintT()
            {
            Console.WriteLine("ProjectB,TeamA,ClassA,PrintT()");
            }

        }
    }
    namespace TeamB
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("ProjectB,TeamB,ClassA,Print()");
            }
            public void PrintT()
            {
                Console.WriteLine("ProjectB,TeamA,ClassA,PrintT()");
            }

        }
    }
}
