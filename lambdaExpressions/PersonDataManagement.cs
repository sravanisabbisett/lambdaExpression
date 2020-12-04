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
        public void addDetails()
        {
            person.Add(new Person("2345678", "sravani", "GandhiChowk", 13));
            person.Add(new Person("2356789", "rupika", "AswiniBuildings", 12));
            person.Add(new Person("1234567", "lakshmi", "vujayanthitraders", 23));
            person.Add(new Person("2345678", "sri", "arumodayacolony", 18));
            person.Add(new Person("456789", "sailja", "1town", 47));
            person.Add(new Person("567890", "akhilesh", "perungudi", 25));
            person.Add(new Person("678901", "badarinath", "bantumilli", 50));
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
    }
}
