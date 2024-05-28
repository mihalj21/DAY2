using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootCamp
{
    public abstract class Person: IPerson
    {
        public string FirstName { get; set; }
         public string LastName { get; set; }


        public Person() { }
        public Person(string firstName, string lastName) {
            FirstName = firstName;
            LastName = lastName;
    }
    }
}
