using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> People = new List<Person>();
            AddDefaultData(People);
        }

        public static void AddDefaultData(List<Person> people)
        {
            people.Add(new Person("SSN1", "Name 1", "Address 1", 21));
            people.Add(new Person("SSN2", "Name 2", "Address 2", 21));
            people.Add(new Person("SSN3", "Name 3", "Address 3", 21));
            people.Add(new Person("SSN4", "Name 4", "Address 4", 21));
        }
    }
}
