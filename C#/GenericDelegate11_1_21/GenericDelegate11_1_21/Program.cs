using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDelegate11_1_21
{
    class Program
    {
        delegate void MyGenericDelegate<S>(S arg);
        static void Main(string[] args)
        {
            // delegatesssss
            MyGenericDelegate<string> myGenericDelegateString = new MyGenericDelegate<string>(StringUpper);
            myGenericDelegateString("Ozan Üstündağ");
            MyGenericDelegate<int> myGenericDelegateInt = new MyGenericDelegate<int>(IntUpper);
            myGenericDelegateInt(1);
            Console.ReadLine();
        }
        static void StringUpper(string arg)
        {
            Console.WriteLine("Arg Metnini Büyüt: " + arg.ToUpper());
        }
        static void IntUpper(int arg)
        {
            Console.WriteLine("Arg sayısı arttır: " + ++arg);
        }
    }
}
