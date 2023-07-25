using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ex1
{
    class Catalogue
    {
        private string className;
        private readonly List<Student> students;

        public Catalogue(string className, List<Student> students)
        {
            this.className = className;
            this.students = students;
        }

        public string GetClassNameAndStudents()
        {
            return $"Class name: {className}. Students: {string.Join(", ", students.Select(student => student.GetStudentNames()))}";
        }
        public Student GetValedictorian()
        {
            return students[students.FindIndex(student => student.ArithmeticAverage() == students.Max(student => student.ArithmeticAverage()))];
        }
    }
}
