using System;

namespace lambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Person Data Management");
            PersonDataManagement dataManagement = new PersonDataManagement();
            dataManagement.AddDetails();
            Console.WriteLine("Retriving first two records whose age is less than 60");
            dataManagement.RetriveFirstTwoRecords();
            Console.WriteLine("Checking wether there is teeneager in the list");
            dataManagement.CheckTeenager();
            Console.WriteLine("calculating the average age in the list");
            dataManagement.CalculateAvgAgeInTheList();
            Console.ReadKey();
        }
    }
}
