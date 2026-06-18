using System;
using System.Collections.Generic;
using System.Linq;

namespace Chapter4
{
    class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public int Experience { get; set; }

        public static void Main()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee { Name = "Ram", Department = "Engineering", Experience = 7 },
                new Employee { Name = "Sita", Department = "HR", Experience = 6 },
                new Employee { Name = "Hari", Department = "Engineering", Experience = 4 },
                new Employee { Name = "Gita", Department = "Engineering", Experience = 10 },
                new Employee { Name = "Shyam", Department = "Finance", Experience = 8 }
            };

            var result =
                from emp in employees
                where emp.Department == "Engineering" && emp.Experience > 5
                select emp.Name;

            Console.WriteLine("Engineering employees with more than 5 years of experience:");

            foreach (var name in result)
            {
                Console.WriteLine(name);
            }

            Console.ReadKey();
        }
    }
}