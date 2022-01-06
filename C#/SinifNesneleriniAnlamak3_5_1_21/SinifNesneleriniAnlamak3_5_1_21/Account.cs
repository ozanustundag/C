using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinifNesneleriniAnlamak3_5_1_21
{
    class Account
    {

        public Account()
        {

        }
        public string GetAccount(string userNmae)
        {
            if (!string.IsNullOrEmpty(userNmae))
            {
                //işlem yap
            }
            if (!string.IsNullOrWhiteSpace(userNmae))
            {
                //işlem yap
            }
            else
            {
            }
            return "dijibil";
        }
        public string GetAccount(int userId)
        {
            if (userId>0)
            {
                return "ozan baba";
            }
            else
            {
                throw new Exception("Hata!");
            }
            return string.Empty;
        }
    }
}
