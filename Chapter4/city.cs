using System;
using System.Collections.Generic;
using System.Linq;
namespace Chapter4
{

    class Student
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Campus { get; set; }
    }

    class city
    {
        static void Main()
        {
            List<Student> students = new List<Student>()
        {
            new Student { Name="Ram", Address="Kritipur", Campus="Patan Multiple Campus" },
            new Student { Name="Sita", Address="Kathmandu", Campus="Patan Multiple Campus" },
            new Student { Name="Hari", Address="Kritipur", Campus="Tri-Chandra Campus" },
            new Student { Name="Gita", Address="Kritipur", Campus="Patan Multiple Campus" }
        };

            var result = from s in students
                         where s.Address == "Kritipur"
                         && s.Campus == "Patan Multiple Campus"
                         select s;

            Console.WriteLine("Selected Students:");

            foreach (var student in result)
            {
                Console.WriteLine(student.Name);
            }
        }
    }
}