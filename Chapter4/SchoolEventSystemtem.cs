using System;
using System.Collections.Generic;

namespace SchoolEventSystem
{
    public delegate void StudentAddedEventHandler(string name, int age);

   
    class School
    {
        
        private List<string> students = new List<string>();

        
        public event StudentAddedEventHandler StudentAdded;

     
        public void AddStudent(string name, int age)
        {
            
            students.Add(name + " - " + age);

            
            OnStudentAdded(name, age);
        }

        
        protected virtual void OnStudentAdded(string name, int age)
        {
            if (StudentAdded != null)
            {
                StudentAdded(name, age);
            }
        }
    }

    
    class EventProgram
    {
        static void Main(string[] args)
        {
            
            School school = new School();

            
            school.StudentAdded += DisplayMessage;

            
            school.AddStudent("Ram", 16);
            school.AddStudent("Sita", 15);

            Console.ReadLine();
        }

        
        static void DisplayMessage(string name, int age)
        {
            Console.WriteLine("Student Added Successfully!");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine();
        }
    }
}