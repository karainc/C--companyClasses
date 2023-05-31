using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.   
             Company cuttingEdgeInc = new Company ("Mystery Incorporated");

            // Create three employees
            Employee employee1 = new Employee("Karen", "Kackles", new DateTime(2010, 7, 13));
            Employee employee2 = new Employee("Mark", "FBI", new DateTime(2010, 9, 13));
            Employee employee3 = new Employee("Jack","Homicide", new DateTime(2012, 9, 03));

            // Assign the employees to the company
              cuttingEdgeInc.AddEmployee(employee1);
              cuttingEdgeInc.AddEmployee(employee2);
              cuttingEdgeInc.AddEmployee(employee3);
            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */

            Console.WriteLine($"Company:{cuttingEdgeInc.Name}");
            Console.WriteLine("Employees:");
            foreach (Employee employee in cuttingEdgeInc.Employees)
            {
                Console.WriteLine($"{employee.Name}");
            }
            
            cuttingEdgeInc.ListEmployees();
        }
    }
}


