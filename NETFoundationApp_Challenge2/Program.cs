using System;
using System.Collections.Generic;

namespace NETFoundationApp_Challenge2
{
    class Program
    {

        static bool IsCorrectGrade(int grade)
        {
            return grade >= 0 && grade <= 100;
        }
        static void Main()
        {
            
            Console.Write("Enter a number of students: ");
            int studentsCount = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a number of grades: ");
            int gradesCount = Convert.ToInt32(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < studentsCount; i++)
            {
                Console.Write($"Enter first name of student {i + 1}: ");
                string firstName = Console.ReadLine();
                Console.Write($"Enter last name of student {i + 1}: ");
                string lastName = Console.ReadLine();
                Console.WriteLine($"Enter grades of student {i + 1 } - {firstName} {lastName}: ");
                List<int> grades = new  List<int>();
                int grade;
                for (int j = 0; j < gradesCount; j++)
                {
                    Console.Write($"Enter a grade {j + 1}: ");
                    do
                    {
                        grade = Convert.ToInt32(Console.ReadLine());
                        if (IsCorrectGrade(grade)) break;
                        else
                        {
                            Console.WriteLine();
                            Console.Write($"Enter correct grade {j + 1}:");
                        }
                    } while (true);
                    grades.Add(grade);
                }
                students.Add(new Student(firstName, lastName, grades));
            }

            foreach(var student in students)
            {
                student.Print();
            }
        }
    }
}
