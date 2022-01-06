using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass9_1_21
{
    class Program
    {
        static void Main(string[] args)
        {
            People people = new People();
            people.Birthday = DateTime.Now;
            people.Email = "ozi@gmail.com";
            people.FirstName = "ozi";
            people.LastName = "nnan";
            Console.WriteLine(people.GetFullname() + "\n" + people.GetEmail("2"));
            Console.ReadLine();
        }
    }
}
