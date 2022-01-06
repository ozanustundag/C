using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractObjects11_1_21
{
    class Isci : Calisan
    {
        public Isci()
        {
            Unvan = "işçi";
        }
        public override double GetSalary()
        {
            return 2000;
        }
    }
}
