using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyMorphisim_CokBicimlilik_5_1_21
{
    class Basket
    {
        private List<Product> products = new List<Product>();
        public void AddBasket(Product Newproduct)
        {
            if (Newproduct != null)
            {
                products.Add(Newproduct);
            }
        }
        public double TotalPrice()
        {
            double TotalPrice = 0;
            foreach (var product in products)
            {
                TotalPrice += product.Price;
            }
            return TotalPrice;
        }
        public double TotalPriceWithKdv()
        {
            double TotalPriceWithKdv = 0;
            foreach (var product in products)
            {
                TotalPriceWithKdv += product.SetKdv();
            }
            return TotalPriceWithKdv;
        }
        public List<Product> GetProducts()
        {
            return products;
        }
    }
}
