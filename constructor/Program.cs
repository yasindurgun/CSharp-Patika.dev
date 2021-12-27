using System;

namespace constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(1,"Yasin", 123456789);
            Employee emp2 = new Employee();

            Console.ReadKey();
        }

    }

    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int No { get; set; }

        public Employee(int id, string name, int no)
        {
            Id = id;
            Name = name;
            No = no;
        }
        public Employee()
        {

        }
    }
}
