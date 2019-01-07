using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                students.Add(Student.Parse(input));  
            }

            List<Student> filteredStudents = FilterStudents(students);

            List<Student> orederedStudents = filteredStudents
                .OrderBy(s => s.Name)
                .ThenByDescending(s => s.AverageGrades)
                .ToList(); 

            foreach (var s in orederedStudents)

                Console.WriteLine($"{s.Name} -> {s.AverageGrades:F2}");


        }

        public static List<Student> FilterStudents(List<Student> students)
        {
            List<Student> result = new List<Student>(); 

            foreach (var student in students)
            {
                if (student.AverageGrades >= 5)
                    result.Add(student); 
            }

            return result;
        }
    } 

    class Student
    {
        public Student(string name, List<double> grades)
        {
            Name = name;
            Grades = grades ; 
        }
        public string Name { get; set; }

        public List<double> Grades { get; set; }

        //public double AverageGrades => Grades.Average() - much shorter !

        public double AverageGrades
        {
            get
            {
                return Grades.Average(); 
            }
        }

        public static Student Parse(string input)
        {
            var args = input.Split();
            var name = args[0];
            var grades = args.Skip(1).Select(double.Parse).ToList();

            Student result = new Student(name, grades);

            return result; 
        }
    }
}
