using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyMorphisim_CokBicimlilik_5_1_21
{
    class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public string ProductCode { get; set; }
        public string Uretici { get; set; }

        public Product()
        {

        }
        public Product(int productId,string productName,double price,string productCode)
        {
            this.ProductId = productId;
            this.ProductName = productName;
            this.Price = price;
            this.ProductCode = productCode;
        }
        public double SetKdv()
        {
            return this.Price * 1.18;
        }
    }
}
