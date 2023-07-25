using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex1
{
    class Student
    {
        public string firstName;
        public string lastName;
        private readonly List<int> grades;

        public Student(string firstName, string lastName, List<int> grades)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.grades = grades;
        }

        public int ArithmeticAverage()
        {
            return grades.Sum() / grades.Count;
        }

        public string GetStudentInfo()
        {
            return $"Last name: {lastName}, First name: {firstName}\n Grades: {string.Join(", ", grades)}";
        }

        public string GetStudentNames()
        {
            return $"{lastName} {firstName}";
        }
    }
}
