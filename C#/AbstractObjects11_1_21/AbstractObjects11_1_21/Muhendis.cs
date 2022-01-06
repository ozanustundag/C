using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractObjects11_1_21
{
    class Muhendis : Calisan
    {
        public Muhendis()
        {
            Unvan="Muhendis";
        }
        public override double GetSalary()
        {
            return 4000;
            
        }
    }
}
