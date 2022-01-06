using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClasses11_1_21
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    class A:B
    {
        public int a { get; set; }
    }
    sealed class B
    {
        public int b { get; set; }
    }
}
