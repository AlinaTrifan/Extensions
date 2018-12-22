using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Extensions
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "My awsome students!";
            int wNo = Extensions.WordCount(myString);

            int wNoFromExtension = myString.WordCountExtension();

            var now = DateTime.Now;
            Console.WriteLine(now.RoundToHalfHour());

            List<Person> persons = new List<Person>();

            persons.Add(new Person()
            {
                City = "Iasi",
                Country = "Romania",
                FirstName = "gigi",
                LastName = "Bombonica"
            });

            persons.Add(new Person()
            {
                City = "Botosani",
                Country = "Romania",
                FirstName = "Germany",
                LastName = "Muschi"
            });

            persons.Add(new Person()
            {
                City = "Iasi",
                Country = "Germany",
                FirstName = "Romania",
                LastName = "Muschi"
            });

            //anonymous 
            var student = new
            {
                Name = "Student1",
                Course = ".NET"
            };

            Console.WriteLine(student.Course + student.Name);

           
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            int oddNumbers = numbers.Count(n => n % 2 == 1);

            //with linq
            var personInCity = persons.Where(person => person.City == "Iasi")
                .OrderBy(x => x.LastName) //method chaining cand folosesti mai multe metode una dupa cealalata
                .OrderByDescending(x=>x.Country.WordCountExtension()).ToList();

            //classic
            var personInCityClass = new List<Person>();
            foreach (var person in persons)
            {
                if (person.City == "Iasi")
                {
                    personInCityClass.Add(person);
                }
            }

            
        }
    }
}
