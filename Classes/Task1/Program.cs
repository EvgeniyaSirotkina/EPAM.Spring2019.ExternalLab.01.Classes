using System;

namespace Task1
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("=== Task 1 ===\n");

            // #1
            // Create an array of five objects, element with index 2 must be empty, 
            // the last element must be created using the default constructor, 
            // the rest must be created using the parameterized constructor
            var staff = new EmployeeTravelExpense[]
                {
                    new EmployeeTravelExpense("Anjelika Dzyatlova", 25m, 10),
                    new EmployeeTravelExpense("Ivan Melnikau", 30m, 12),
                    null,
                    new EmployeeTravelExpense("Petr Meleshnichenka", 10m, 3),
                    new EmployeeTravelExpense(),
                };

            // #2 Display all array objects to the console using the Show() method
            foreach (var employee in staff)
            {
                if (employee != null)
                {
                    employee.Show();
                }
            }

            // #3 Change transport costs in the last item in the array
            staff[staff.Length - 1].Transport = 10;

            // #4 Display the total duration of the first two business trips
            Console.WriteLine($"Duration = {staff[0].Days + staff[1].Days}");

            // #5 Print objects from array to console using ToString()
            foreach (var employee in staff)
            {
                Console.WriteLine(employee);
            }

            Console.ReadKey();
        }
    }
}
