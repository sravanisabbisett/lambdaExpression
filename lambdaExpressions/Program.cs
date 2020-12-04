using System;

namespace lambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Person Data Management");
            PersonDataManagement dataManagement = new PersonDataManagement();
            dataManagement.addDetails();
            dataManagement.RetriveFirstTwoRecords();
            Console.ReadKey();
        }
    }
}
