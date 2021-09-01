using System;
using System.Collections.Generic;
using System.Linq;

namespace NETFoundationApp_Challenge2
{
    class Student
    {
        private string _firstname;
        private string _lastName;
        private List<int> _grades;
        private Dictionary<int, string> gradeMap = new Dictionary<int, string>
        {
            [0] = "F",
            [60] = "D",
            [70] = "C",
            [80] = "B",
            [90] = "A"
        };
        public Student(string firstName, string lastName, List<int> grades)
        {
            this._firstname = firstName;
            this._lastName = lastName;
            this._grades = grades;
        }

        public int GetAverageGrade()
        {
            return Convert.ToInt32(this._grades.Sum() / this._grades.Count);
        }

        public string GetLetterGrade()
        {
            return gradeMap.OrderByDescending(x => x.Key).FirstOrDefault(x => x.Key <= GetAverageGrade()).Value;
        }

        public void Print()
        {
            Console.WriteLine($"{this._firstname} {this._lastName} {GetAverageGrade()} {GetLetterGrade()}");
        }

    }
}
