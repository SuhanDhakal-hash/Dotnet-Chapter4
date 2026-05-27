using System;
using System.Collections.Generic;

namespace SchoolEventSystem
{
    // Delegate for event
    public delegate void StudentAddedEventHandler(string name, int age);

    // School class
    class School
    {
        // List of students
        private List<string> students = new List<string>();

        // Event declaration
        public event StudentAddedEventHandler StudentAdded;

        // Method to add student
        public void AddStudent(string name, int age)
        {
            // Store student in list
            students.Add(name + " - " + age);

            // Trigger event
            OnStudentAdded(name, age);
        }

        // Method to raise event
        protected virtual void OnStudentAdded(string name, int age)
        {
            if (StudentAdded != null)
            {
                StudentAdded(name, age);
            }
        }
    }

    // Main program class
    class EventProgram
    {
        static void Main(string[] args)
        {
            // Create school object
            School school = new School();

            // Subscribe to event
            school.StudentAdded += DisplayMessage;

            // Add students
            school.AddStudent("Ram", 16);
            school.AddStudent("Sita", 15);

            Console.ReadLine();
        }

        // Event handler method
        static void DisplayMessage(string name, int age)
        {
            Console.WriteLine("Student Added Successfully!");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine();
        }
    }
}