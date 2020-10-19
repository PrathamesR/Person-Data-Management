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
            Console.WriteLine("Age Less than 60:");
            GetLessThan60(people);
            Console.WriteLine("\nAge Between 13 to 18:");
            GetBetween13to18(people);
            Console.Write("\nAverage Age: "+GetAverageAge(people));
            Console.WriteLine("");
            FindPerson(people, "Abc");
            Console.Read();
        }

        public static void AddDefaultData(List<Person> people)
        {
            people.Add(new Person("SSN1", "Abc", "Address 1", 73));
            people.Add(new Person("SSN2", "Def", "Address 2", 50));
            people.Add(new Person("SSN3", "Ghi", "Address 3", 40));
            people.Add(new Person("SSN4", "Hijk", "Address 5", 15));
            people.Add(new Person("SSN5", "Lmno", "Address 6", 25));
            people.Add(new Person("SSN6", "pqrs", "Address 7", 18));
        }

        public static void GetLessThan60(List<Person> people)
        {
            foreach (Person person in people.FindAll(e => (e.Age < 60)).Take(2).ToList()) 
            {
                Console.WriteLine(person.Name+" Age: " + person.Age);
            }
        }

        public static void GetBetween13to18(List<Person> people)
        {
            foreach (Person person in people.FindAll(e => (e.Age >= 13 && e.Age <= 18)))
                Console.WriteLine(person.Name + " Age:" + person.Age);
        }

        public static double GetAverageAge(List<Person> people)
        {
            return people.Average(e => e.Age);
        }

        public static void FindPerson(List<Person> people,string name)
        {
            if (people.Any(e => (name.Equals(e.Name))))
                Console.WriteLine(name + " is present in the list");
            else
                Console.WriteLine(name + " is not present in the list");
        }

    }
}
