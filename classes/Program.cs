using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //    class MyClass
            //    {
            //    public int MyProperty { get; set; }
            //    }

            //Erişim Belirleyiciler
            //Public, private, ınternal, protected

            Employee emp = new Employee();
            emp.Name = "Ayse";
            emp.Surname = "Kara";
            emp.No = 256465156;
            emp.Departmant = "HR";

            emp.ShowInfos();

            Console.ReadKey();
        }
    }

    class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int No { get; set; }
        public string Departmant { get; set; }

        public void ShowInfos()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Surname: {Surname}");
            Console.WriteLine($"No: {No}");
            Console.WriteLine($"Departmant: {Departmant}");
        }
    }
}
