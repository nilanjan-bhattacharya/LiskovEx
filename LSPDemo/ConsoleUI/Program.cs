using DemoLibrary;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager accountingVP = new Manager
            {
                FirstName = "Emma",
                LastName = "Stone",
            };
            accountingVP.CalculatePerHourRate(4);

            Employee emp = new Employee
            {
                FirstName = "Tim",
                LastName = "Corey",
            };

            emp.AssignManager(accountingVP);
            emp.CalculatePerHourRate(2);

            System.Console.WriteLine($"{ emp.FirstName }'s salary is ${ emp.Salary }/Hour.");
        }
    }
}
