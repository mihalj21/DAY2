using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootCamp
{
    public class Club
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public string League { get; set; }

        public Club() { }

        public Club(string name, string country, string league) { 
         Name = name;
         Country = country;
         League = league;
        }
    }
}
