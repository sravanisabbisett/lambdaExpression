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
            Console.WriteLine("***Retriving first two records whose age is less than 60***\n");
            dataManagement.RetriveFirstTwoRecords();
            Console.WriteLine("\n***Checking wether there is teeneager in the list***\n");
            dataManagement.CheckTeenager();
            Console.WriteLine("\n***calculating the average age in the list***\n");
            dataManagement.CalculateAvgAgeInTheList();
            Console.WriteLine("\n***Checking wether the person is present or not***\n");
            var result=dataManagement.CheckNamePersentOrNot("manju");
            Console.WriteLine("checking wether the name manju present in the list or not\n"+result);
            var checkName=dataManagement.CheckNamePersentOrNot("rupika");
            Console.WriteLine("Checking wether the name rupika present in the list or not\n"+checkName);
            Console.WriteLine("\n***Skips the person whose age are less than 60 and only printing the person whose age is greater than 60***\n");
            dataManagement.SkipRecordsWhoseAgeLessThan60();
            Console.WriteLine("\n***Removing one element in the list***\n");
            dataManagement.RemoveElementInTheList("sravani");
            Console.ReadKey();
        }
    }
}
