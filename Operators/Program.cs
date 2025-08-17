using System;

namespace EmployeeComparisonApp
{
    // Define the Employee class
    public class Employee
    {
        // Public properties for the Employee
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Overload the '==' operator to compare Employee objects by Id
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // If both are the same reference or both are null, return true
            if (ReferenceEquals(emp1, emp2))
                return true;

            // If one is null but not both, return false
            if ((object)emp1 == null || (object)emp2 == null)
                return false;

            // Compare based on Id
            return emp1.Id == emp2.Id;
        }

        // Overload the '!=' operator as required when overloading '=='
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1 == emp2);
        }

        // Override Equals method for proper equality comparison
        public override bool Equals(object obj)
        {
            // Check if the object is null or not of type Employee
            if (obj == null || !(obj is Employee))
                return false;

            // Cast the object to Employee and compare Ids
            Employee other = (Employee)obj;
            return this.Id == other.Id;
        }

        // Override GetHashCode to match Equals logic
        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }
    }

    // Main program class
    class Program
    {
        // Entry point of the application
        static void Main(string[] args)
        {
            // Create the first Employee object and assign values
            Employee employee1 = new Employee
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe"
            };

            // Create the second Employee object and assign values
            Employee employee2 = new Employee
            {
                Id = 1,
                FirstName = "Fatima",
                LastName = "AlBashar"
            };

            // Compare the two employees using the overloaded '==' operator
            bool areEqual = employee1 == employee2;

            // Output the result of the equality comparison
            Console.WriteLine($"Are employee1 and employee2 equal? {areEqual}");

            // Compare using the '!=' operator
            bool areNotEqual = employee1 != employee2;

            // Output the result of the inequality comparison
            Console.WriteLine($"Are employee1 and employee2 not equal? {areNotEqual}");

            // Wait for user input to keep the console window open
            Console.ReadKey();
        }
    }
}
