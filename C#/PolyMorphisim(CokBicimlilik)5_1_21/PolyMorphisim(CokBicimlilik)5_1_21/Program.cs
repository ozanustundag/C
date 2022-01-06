using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyMorphisim_CokBicimlilik_5_1_21
{
    class Program
    {
    
        static void Main(string[] args)
        {
            Basket basket = new Basket();
            Bread bread = new Bread(BreadType.Odun);
            Console.WriteLine(Gramaj.Ikiyuz);
            Tekstil tekstil = new Tekstil();
            tekstil.Beden = 40;
            tekstil.Marka = TekstilMarka.Adidas;
            tekstil.ProductName = "Özel Dikim";
            tekstil.Price = 100;
            basket.AddBasket(tekstil);
            basket.AddBasket(bread);
            Console.WriteLine("Toplam Fiyat(Kdv Hariç)= " + basket.TotalPrice()+"\n");
            Console.WriteLine("Toplam Fiyat(Kdv Dahil)= " + basket.TotalPriceWithKdv() + "\n");
            Console.WriteLine("KDV= " + (basket.TotalPriceWithKdv() - basket.TotalPrice())+"\n");
            Console.WriteLine("Sepettekiler:\n");
            foreach (var prd in basket.GetProducts())
            {
                Console.WriteLine(prd.ProductName + "-" + prd.Price+"\n");
            }

            Console.ReadLine();

        }
    }
}
