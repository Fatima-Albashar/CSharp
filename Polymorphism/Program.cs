using System;

namespace InterfacePolymorphismApp
{
    // Define an interface called IQuittable
    interface IQuittable
    {
        // Declare a method signature for Quit (no implementation here)
        void Quit();
    }

    // Define an Employee class that implements the IQuittable interface
    class Employee : IQuittable
    {
        // Additional properties (optional for context)
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Implement the Quit method from the IQuittable interface
        public void Quit()
        {
            // Example implementation - you can customize this behavior
            Console.WriteLine($"{FirstName} {LastName} has quit the job.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a new Employee object and set some properties
            Employee emp = new Employee() 
            { 
                FirstName = "Fatima", 
                LastName = "AlBashar" 
            };

            // Use polymorphism to assign the Employee object to an IQuittable interface variable
            IQuittable quittableEmp = emp;

            // Call the Quit method using the interface type
            quittableEmp.Quit();

            // Pause the console so we can read the output
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
