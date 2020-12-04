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
            Console.WriteLine("********Retriving first two records whose age is less than 60*********\n");
            dataManagement.RetriveFirstTwoRecords();
            Console.WriteLine("\n**********Checking wether there is teeneager in the list********\n");
            dataManagement.CheckTeenager();
            Console.WriteLine("calculating the average age in the list");
            dataManagement.CalculateAvgAgeInTheList();
            Console.WriteLine("\n******Checking wether the person is present or not*******\n");
            var checkPersent=dataManagement.CheckNamePersentOrNot("manju");
            Console.WriteLine("Checking for the name manju present inn list or not::"+checkPersent);
            var checkNameinList = dataManagement.CheckNamePersentOrNot("sravani");
            Console.WriteLine("Checking for the name sravani present inn list or not::" + checkNameinList);
            Console.WriteLine("\n**Skips the person whose age are less than 60 and only printing the person whose age is greater than 60**\n");
            dataManagement.SkipRecordsWhoseAgeLessThan60();
            Console.ReadKey();
        }
    }
}
