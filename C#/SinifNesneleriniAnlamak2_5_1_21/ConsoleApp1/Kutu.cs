using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Kutu
    {
        private float genislik;
        private float yukseklik; //fieldlar private olmalıdır.
        private float uzunluk;

        public Kutu()//nesne kurulurken çalışır.
        {

        }
        //destructor(yıkıcı metot) nesne örneği ölürken çalışır
        ~Kutu()
        {
            Console.WriteLine("Sinif Yİkiliyor");
            Console.ReadLine();
        }
        //Kapsullume(Encapsulation)
        #region GetterandSetter Methods
        public float GetUzunluk()
        {
            return uzunluk; 
        }
        public void SetUzunluk(float uzunluk)
        {
            if (uzunluk>=0)
            {
                this.uzunluk = uzunluk;
            }
            else
            {
                this.uzunluk = 1;
            }
            
        }
        #endregion
        //properties
        #region property
        public float Genislik {
            get
            {
                return genislik;
            }
            set
            {
                if (value>=0)
                {
                    genislik = value;
                }
                else
                {
                    genislik = 2;
                }
               
            }
        }
        #endregion
        public int MyProperty { get; set; } // fielda oluşturmuş gibi.hiç bir denetlemeye tabi tutamaıyoruz.
        public float Yukseklik { get => yukseklik; set => yukseklik = value; } // ctrl+r+e
    }
}
