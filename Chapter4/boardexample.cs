using System;
using System.Collections.Generic;
using System.Linq;

namespace Chapter4
{
    class Employee2
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Address { get; set; }
    }

    class boardexample
    {
        static void Main()
        {
            List<Employee2> employees = new List<Employee2>()
            {
                new Employee2 { Id = 1, Name = "Ram", Salary = 25000, Address = "Kathmandu" },
                new Employee2 { Id = 2, Name = "Hari", Salary = 18000, Address = "Lalitpur" },
                new Employee2 { Id = 3, Name = "Sita", Salary = 30000, Address = "Kathmandu" },
                new Employee2 { Id = 4, Name = "Gita", Salary = 15000, Address = "Bhaktapur" }
            };

            var result = from e in employees
                         where e.Salary > 20000 &&
                               e.Address == "Kathmandu"
                         select e;

            Console.WriteLine("Selected Employees:");

            foreach (var emp in result)
            {
                Console.WriteLine(emp.Name + " " + emp.Salary);
            }

            Console.ReadKey();
        }
    }
}