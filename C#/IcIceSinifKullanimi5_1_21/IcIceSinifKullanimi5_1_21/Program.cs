using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcIceSinifKullanimi5_1_21
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            a.PropA = 1;
            A.B B = new A.B();
            B.PropB = 5;
        }
    }
    class A
    {
        public int PropA { get; set; }
        public A()
        {

        }
        public class B
        {
            public int PropB { get; set; }
            public B()
            {

            }
        }
    }
}
