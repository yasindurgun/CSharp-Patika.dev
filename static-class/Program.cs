using System;

namespace static_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Number of Employees: {Employee.NumberOfEmployee}");

            Employee emp1 = new Employee("Yasin","Durgun","IT");

            Console.WriteLine($"Number of Employees: {Employee.NumberOfEmployee}");
            Console.WriteLine("*****");
            Console.WriteLine("Result: " + Operations.Sum(100,150));
            Console.ReadKey();
        }
    }

    class Employee
    {
        private static int numberOfEmployee;
        public static int NumberOfEmployee { get => numberOfEmployee;}

        private string Name;
        private string Surname;
        private string Departmant;

        static Employee()
        {
            numberOfEmployee = 0;
        }
        public Employee(string name, string surname, string departmant)
        {
            Name = name;
            Surname = surname;
            Departmant = departmant;
            numberOfEmployee++;
        }
    }

    static class Operations
    {
        public static long Sum(int number1, int number2)
        {
            return number1 + number2;
        }
    }
}
