using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyMorphisim_CokBicimlilik_5_1_21
{
    public enum TekstilMarka
    {
        Kigili=1,
        Beymen=2,
        PierreCarden=3,
        Adidas=4,
        KardeslerKundura=5
    }
    class Tekstil:Product
    {
        
        public string Tur { get; set; }
        public int Beden { get; set; }
        public TekstilMarka Marka { get; set; }
        public static List<Tekstil> SearchByBrand(TekstilMarka marka)
        {
            List<Tekstil> textileProducts = new List<Tekstil>();
            textileProducts.Add(new Tekstil()
            {
                ProductName = "Pantolon",
                Beden = 40,
                Price=100,
                Marka=TekstilMarka.Beymen
            }
            );
            textileProducts.Add(new Tekstil()
            {
                ProductName = "Gömlek",
                Beden = 30,
                Price = 100,
                Marka = TekstilMarka.Adidas

            });
            List<Tekstil> returnProducts = new List<Tekstil>();
            foreach (var textile in textileProducts)
            {
                if (textile.Marka==marka)
                {
                    returnProducts.Add(textile);
                }
                
            }
            return returnProducts;
            
        }
        public static List<Tekstil> SearchByBrand(string marka)
        {
            List<Tekstil> textileProducts = new List<Tekstil>();
            textileProducts.Add(new Tekstil()
            {
                ProductName = "Pantolon",
                Beden = 40,
                Price = 100,
                Marka = TekstilMarka.Beymen
            }
            );
            textileProducts.Add(new Tekstil()
            {
                ProductName = "Gömlek",
                Beden = 30,
                Price = 100,
                Marka = TekstilMarka.Adidas

            });
            List<Tekstil> returnProducts = new List<Tekstil>();
            foreach (var textile in textileProducts)
            {
                if (marka==textile.Marka.ToString())
                {
                    returnProducts.Add(textile);

                }
            }
            return returnProducts;

        }

    }
}
