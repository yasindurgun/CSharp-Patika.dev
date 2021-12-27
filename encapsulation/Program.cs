using System;

namespace encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Yasin","Durgun",151152121,4);
            s1.ShowInfo();
            Console.ReadKey();
        }
    }

    class Student
    {
        private string name;
        private string surname;
        private int studentNo;
        private int classroom;

        public Student(string name, string surname, int studentNo, int classRoom)
        {
            Name = name;
            Surname = surname;
            StudentNo = studentNo;
            ClassRoom = classRoom;
        }

        public Student()
        {

        }

        public string Name { get => name; set => name = value; }
        public string Surname {
            get { return surname; }
            set { surname = value; } 
        }
        public int StudentNo { get => studentNo; set => studentNo = value; }
        public int ClassRoom { get => classroom; set => classroom = value; }

        public void ShowInfo()
        {
            Console.WriteLine("********Student Infos***************");
            Console.WriteLine($"Student Name: {Name}");
            Console.WriteLine($"Surname Name: {Surname}");
            Console.WriteLine($"StudentNo Name: {StudentNo}");
            Console.WriteLine($"ClassRoom Name: {ClassRoom}");
        }
    }
}
