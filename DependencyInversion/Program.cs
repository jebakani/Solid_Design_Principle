using System;

namespace DependencyInversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IGetAccess operation = AccessFactory.GetOperationManagementObject();
            operation.GenerateEmployeeReport(operation.GetDetails());
        }
    }
}
