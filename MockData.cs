using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_1
{
    public class MockData
    {



        public static Dictionary<string, Person> CreateData()
        {
            Dictionary<string, Person> Persons = new Dictionary<string, Person>();

            Person person1 = new Person() { FirstName = "Billy", LastName = "Bob", Address = "123 Mckdonald St.", MobilePhone = "(443)-456-7890", WorkPhone="(999)-998-7654" };
            Persons.Add(person1.FullName, person1);


            Person person2 = new Person() { FirstName = "Billy", LastName = "Bob", Address = "123 Mckdonald St.", MobilePhone = "(443)-456-7890", WorkPhone = "(999)-998-7654" };
            Persons.Add(person2.FullName, person2);


            Person person3 = new Person() { FirstName = "Billy", LastName = "Bob", Address = "123 Mckdonald St.", MobilePhone = "(443)-456-7890", WorkPhone = "(999)-998-7654" };
            Persons.Add(person3.FullName, person3);

            return Persons;
        }
    }
} 