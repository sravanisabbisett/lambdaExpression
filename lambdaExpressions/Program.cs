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
            Console.WriteLine("********Retriving first two records whose age is less than 60*********");
            dataManagement.RetriveFirstTwoRecords();
            Console.WriteLine("**********Checking wether there is teeneager in the list********");
            dataManagement.CheckTeenager();
            Console.WriteLine("calculating the average age in the list");
            dataManagement.CalculateAvgAgeInTheList();
            Console.WriteLine("******Checking wether the person is present or not*******");
            var checkPersent=dataManagement.CheckNamePersentOrNot("manju");
            Console.WriteLine("Checking for the name manju present inn list or not::"+checkPersent);
            var checkNameinList = dataManagement.CheckNamePersentOrNot("sravani");
            Console.WriteLine("Checking for the name sravani present inn list or not::" + checkNameinList);
            Console.ReadKey();
        }
    }
}
