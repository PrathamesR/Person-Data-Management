using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDataManagement
{
    class Person
    {
        public string SSN { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }


        public Person(string SSN, string Name, string Address, int Age)
        {
            this.SSN = SSN;
            this.Name = Name;
            this.Address = Address;
            this.Age = Age;
        }
    }
}
