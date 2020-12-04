using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace lambdaExpressions
{
    class PersonDataManagement
    {
        List<Person> person = new List<Person>();
        /// <summary>
        /// Adds the details in the list.
        /// </summary>
        public void AddDetails()
        {
            person.Add(new Person("2345678", "sravani", "GandhiChowk", 13));
            person.Add(new Person("2356789", "rupika", "AswiniBuildings", 12));
            person.Add(new Person("1234567", "lakshmi", "vujayanthitraders", 23));
            person.Add(new Person("2345678", "sri", "arumodayacolony", 18));
            person.Add(new Person("456789", "sailja", "1town", 47));
            person.Add(new Person("567890", "akhilesh", "perungudi", 25));
            person.Add(new Person("678901", "badarinath", "bantumilli", 70));
            Console.WriteLine("No of persons in list::"+person.Count);
        }

        /// <summary>
        /// Retrives the first two records.
        /// </summary>
        public void RetriveFirstTwoRecords()
        {
            foreach (Person personDetails in person.FindAll(e => e.age < 60).Take(2).ToList())
            {
                Console.WriteLine("Name: " + personDetails.name + " Age: " + personDetails.age);
            }
        }

        /// <summary>
        /// Check wether there is teeanger in the list or not.
        /// </summary>
        public void CheckTeenager()
        {
            if (person.Any(s => (s.age >= 13 && s.age <= 18)))
            {
                Console.WriteLine("Yes we have tenagers in the list");
            }
            else
            {
                Console.WriteLine("No we dont have tenagers in the list");
            }
        }
        /// <summary>
        /// Retrives the average age in the list.
        /// </summary>
        public void CalculateAvgAgeInTheList()
        {
            double age = 0;
            foreach (Person personDetails in person.FindAll(s => s.age < 100).ToList())
            {
                age = age + personDetails.age;
            }
            Console.WriteLine(age);
            Console.WriteLine("Average age in the list is::" + (age / person.Count));
        }

        /// <summary>
        /// Checks the name persent or not.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public string CheckNamePersentOrNot(string name)
        {
            var result = person.Find(s => s.name.Equals(name));
            return result == null ? "Person is not present in the list" : "person is present in the list";
        }

        /// <summary>
        /// Skips the records whose age less than60.
        /// </summary>
        public void SkipRecordsWhoseAgeLessThan60()
        {
            var result = person.SkipWhile(s => s.age < 60);
            foreach (var Skipperson in result)
            {
                Console.WriteLine(Skipperson.name);
            }
        }
    }
}
