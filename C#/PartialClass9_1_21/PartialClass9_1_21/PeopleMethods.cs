using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass9_1_21
{
   partial class People
    {
        public DateTime Birthday
        {
            get
            {
                return birthday;
            }
            set
            {
                birthday = value;
            }
        }

        public string GetFullname()
        {
            return this.FirstName + " " + this.LastName;
        }
        public string GetEmail(string ıd)
        {
            string result = string.Empty;
            if (ıd != null)
            {
                result = this.email;
            }
            return result;
        }
    }
}
