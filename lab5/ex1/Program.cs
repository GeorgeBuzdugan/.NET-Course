using System;
using System.Collections.Generic;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student("George", "Buzdugan", new List<int> { 5, 6, 7, 8, 9 }),
                new Student("Andrei", "Pop", new List<int> { 2, 7, 3, 1, 5 }),
                new Student("Maria", "Popescu", new List<int> { 6, 6, 4, 2, 3 })
            };

            Catalogue catalog = new Catalogue("G1", students);

            Console.WriteLine(catalog.GetValedictorian().GetStudentInfo());
            Console.WriteLine(catalog.GetClassNameAndStudents());
            Console.WriteLine(students[1].ArithmeticAverage());
            Console.WriteLine(students[1].GetStudentInfo());
        }
    }
}
