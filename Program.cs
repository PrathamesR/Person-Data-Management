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
            List<Person> people = new List<Person>();
            AddDefaultData(people);
            GetLessThan60(people);
            Console.Read();
        }

        public static void AddDefaultData(List<Person> people)
        {
            people.Add(new Person("SSN1", "Abc", "Address 1", 73));
            people.Add(new Person("SSN2", "Def", "Address 2", 50));
            people.Add(new Person("SSN3", "Ghi", "Address 3", 40));
            people.Add(new Person("SSN4", "Name", "Address 4", 45));
        }

        public static void GetLessThan60(List<Person> people)
        {
            foreach (Person person in people.FindAll(e => (e.Age < 60)).Take(2).ToList()) 
            {
                Console.WriteLine(person.Name+" Age: " + person.Age);
            }
        }
    }
}
