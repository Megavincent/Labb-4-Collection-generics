namespace Labb_4_Collection_generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Part 1 - Stack
            Console.WriteLine("## Part 1 - Stack ##");

            // Creating objects of the Employee class
            Employee employee1 = new Employee { ID = 1, Name = "John", Gender = "Male", Salary = 50000 };
            Employee employee2 = new Employee { ID = 2, Name = "Alice", Gender = "Female", Salary = 60000 };
            Employee employee3 = new Employee { ID = 3, Name = "Bob", Gender = "Male", Salary = 55000 };
            Employee employee4 = new Employee { ID = 4, Name = "Eva", Gender = "Female", Salary = 70000 };
            Employee employee5 = new Employee { ID = 5, Name = "Charlie", Gender = "Male", Salary = 80000 };

            // Creating a Stack and adding objects to it
            Stack<Employee> employeeStack = new Stack<Employee>();
            employeeStack.Push(employee1);
            employeeStack.Push(employee2);
            employeeStack.Push(employee3);
            employeeStack.Push(employee4);
            employeeStack.Push(employee5);

            // Printing all objects in the Stack
            Console.WriteLine("Objects in Stack:");
            foreach (Employee emp in employeeStack)
            {
                Console.WriteLine($"ID: {emp.ID}, Name: {emp.Name}, Gender: {emp.Gender}, Salary: {emp.Salary}");
                Console.WriteLine($"Items left in Stack: {employeeStack.Count}");
            }

            // Popping all objects from the Stack
            Console.WriteLine("\nPopulating objects from Stack:");
            while (employeeStack.Count > 0)
            {
                Employee emp = employeeStack.Pop();
                Console.WriteLine($"ID: {emp.ID}, Name: {emp.Name}, Gender: {emp.Gender}, Salary: {emp.Salary}");
                Console.WriteLine($"Items left in Stack: {employeeStack.Count}");
            }

            // Pushing all objects back into the Stack
            Console.WriteLine("\nPushing objects back into Stack:");
            employeeStack.Push(employee1);
            employeeStack.Push(employee2);
            employeeStack.Push(employee3);
            employeeStack.Push(employee4);
            employeeStack.Push(employee5);

            // Peeking at two objects in the Stack
            Console.WriteLine("\nPeeking at two objects in Stack:");
            Console.WriteLine($"Peek 1: ID: {employeeStack.Peek().ID}, Name: {employeeStack.Peek().Name}, Gender: {employeeStack.Peek().Gender}, Salary: {employeeStack.Peek().Salary}");
            employeeStack.Pop(); // Removing the peeked item
            Console.WriteLine($"Items left in Stack: {employeeStack.Count}");

            Console.WriteLine($"Peek 2: ID: {employeeStack.Peek().ID}, Name: {employeeStack.Peek().Name}, Gender: {employeeStack.Peek().Gender}, Salary: {employeeStack.Peek().Salary}");
            employeeStack.Pop(); // Removing the peeked item
            Console.WriteLine($"Items left in Stack: {employeeStack.Count}");

            // Checking if item number 3 is in the Stack
            Console.WriteLine("\nChecking if item number 3 is in the Stack:");
            Employee item3 = employeeStack.Contains(employee3) ? employee3 : null;
            Console.WriteLine(item3 != null ? "Item 3 exists in the Stack." : "Item 3 does not exist in the Stack");

            // Part 2 - List
            Console.WriteLine("\n## Part 2 - List ##");

            // Creating a List and adding objects to it
            List<Employee> employeeList = new List<Employee>
        {
            new Employee { ID = 6, Name = "Diana", Gender = "Female", Salary = 75000 },
            new Employee { ID = 7, Name = "Frank", Gender = "Male", Salary = 90000 },
            new Employee { ID = 8, Name = "Grace", Gender = "Female", Salary = 82000 },
            new Employee { ID = 9, Name = "Harry", Gender = "Male", Salary = 67000 },
            new Employee { ID = 10, Name = "Ivy", Gender = "Female", Salary = 72000 }
        };

            // Checking if Employee2 object exists in the List
            Console.WriteLine(employeeList.Contains(employee2) ? "Employee2 object exists in the list." : "Employee2 object does not exist in the list");

            // Finding the first object with Gender = "Male"
            Employee firstMaleEmployee = employeeList.Find(emp => emp.Gender == "Male");
            Console.WriteLine($"First employee with Gender = 'Male': ID: {firstMaleEmployee.ID}, Name: {firstMaleEmployee.Name}, Salary: {firstMaleEmployee.Salary}");

            // Finding all objects with Gender = "Male"
            List<Employee> maleEmployees = employeeList.FindAll(emp => emp.Gender == "Male");
            Console.WriteLine("\nAll employees with Gender = 'Male':");
            foreach (Employee emp in maleEmployees)
            {
                Console.WriteLine($"ID: {emp.ID}, Name: {emp.Name}, Salary: {emp.Salary}");
            }
        }
    }
}
