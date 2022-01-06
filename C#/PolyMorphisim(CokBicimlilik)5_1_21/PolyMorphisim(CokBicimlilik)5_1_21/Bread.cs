using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyMorphisim_CokBicimlilik_5_1_21
{
    public enum BreadType
    {
        Normal=1,
        Kepekli=2,
        Odun=3,
        Çavdar=4,
        Altın=5     
    }
    public enum Gramaj
    {
        Yuz=100,
        Yuzyirmibes=125,
        Ikiyuz=200
    }
    class Bread:Product
    {
        public BreadType Type { get; set; }
        public Gramaj Gram { get; set; }
       
        public Bread(BreadType breadType)
        {
            switch (breadType)
            {
                case BreadType.Normal:
                   this.Price = 1;
                    Gram = Gramaj.Yuz;
                    
                    break;
                case BreadType.Kepekli:
                    this.Price = 1.25;
                    Gram = Gramaj.Yuzyirmibes;
                    break;
                case BreadType.Odun:
                    this.Price = 1.50;
                    Gram = Gramaj.Yuz;
                    break;
                case BreadType.Çavdar:
                    this.Price = 2;
                    Gram = Gramaj.Yuz;
                    break;
                case BreadType.Altın:
                    this.Price = 5;
                    Gram = Gramaj.Ikiyuz;
                    break;
                default:
                    break;
            }
        }

        public Bread()
        {
        }
    }
 
}
