using System;

namespace Chapter4
{
    class Even
    {
        class lambdaexpression
        {
            static void Main()
            {
                
                Func<int, bool> isEven = (int number) => number % 2 == 0;

                Console.Write("Enter an integer: ");
                int number = Convert.ToInt32(Console.ReadLine());

                bool result = isEven(number);
                Console.WriteLine($"Is {number} even? {result}");

                
                Func<string, string, string> stringFormatter =
                    (string firstName, string lastName) => $"{firstName} {lastName}";

                Console.Write("\nEnter your first name: ");
                string firstName = Console.ReadLine();

                Console.Write("Enter your last name: ");
                string lastName = Console.ReadLine();

                string fullName = stringFormatter(firstName, lastName);

                Console.WriteLine($"Full Name: {fullName}");
            }
        }
    }
}