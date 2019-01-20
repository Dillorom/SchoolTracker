using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobCandidate
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("How many years of experience do you have?");
            //var years = int.Parse(Console.ReadLine());

            //switch(years)
            //{
            //    case 0:
            //        Console.WriteLine("Inexperienced");
            //        break;
            //    case 1:
            //        Console.WriteLine("Junior");
            //        break;
            //    case 2:
            //        Console.WriteLine("Intermediate");
            //        break;
            //    case 3:
            //        Console.WriteLine("Associate");
            //        break;
            //    default:
            //        Console.WriteLine("Senior");
            //        break;
            //}
            //Console.ReadKey();


            //StudentsSurvey with arrays

            //Console.WriteLine("How many students in the class?");
            //var studentCount = int.Parse(Console.ReadLine());

            //var studentNames = new string[studentCount];
            //var studentGrades = new int[studentCount];

            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.WriteLine("Student name: ");
            //    studentNames[i] = Console.ReadLine();

            //    Console.WriteLine("Student grade: ");
            //    studentGrades[i] = int.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.WriteLine("Student name: {0}, student grade: {1} ", studentNames[i], studentGrades[i]);
            //}

            //with lists

            //var studentNames = new List<string>();
            //var studentGrades = new List<int>();
            //var adding = true;
            //while (adding)
            //{
            //    Console.WriteLine("Student name: ");
            //    studentNames.Add(Console.ReadLine());

            //    Console.WriteLine("Student grade: ");
            //    studentGrades.Add(int.Parse(Console.ReadLine()));

            //    Console.WriteLine("Do you want to add more? y/n");

            //    if(Console.ReadLine() != "y")
            //    {
            //        adding = false;
            //    }
            //}

            //for (int i = 0; i < studentNames.Count; i++)
            //{
            //    Console.WriteLine("Student name: {0}, student grade: {1} ", studentNames[i], studentGrades[i]);
            //}


            var students = new List<Student>();

            var adding = true;
            while (adding)
            {
                var newStudent = new Student();
                Console.WriteLine("Student name: ");
                newStudent.Name = Console.ReadLine();

                Console.WriteLine("Student grade: ");
                newStudent.Grade = int.Parse(Console.ReadLine());

                Console.WriteLine("Student age: ");
                newStudent.setAge(int.Parse(Console.ReadLine()));

                Console.WriteLine("Student address: ");
                newStudent.Address = Console.ReadLine();

                students.Add(newStudent);
                Student.Count++;
                Console.WriteLine("Student count: {0} ", Student.Count);

                Console.WriteLine("Do you want to add more? y/n");

                if (Console.ReadLine() != "y")
                {
                    adding = false;
                }
            }

            foreach (var student in students)
            {
                Console.WriteLine("Student name: {0}, student grade: {1}, student address: {2} ", student.Name, student.Grade, student.Address);
            }
            Console.ReadKey();
        }
        public class Student
        {
            static public int Count = 0;

            public string Name; //these are called fields, can be set to properties by setting getter and setter
            public int Grade;
            public string Address;
            private int age;

            public void setAge(int number)
            {
                age = number;
            }
            public int Age
            {
                set { Age = value; }
            }
        }
    }
}
