using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double AvgGrade
        {
            get
            {
                return Grades.Average();
            }
        }
    }

    static void Main()
    {
        Student s = new Student();

        int n = int.Parse(Console.ReadLine());
        List<Student> bestStudents = new List<Student>();

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            s.Name = input[0];
            s.Grades = new List<double>();
            s.Grades = input.Skip(1).Select(double.Parse).ToList();
            if (s.AvgGrade >= 5.00)
            {
                bestStudents.Add(new Student
                {
                    Name = input[0],
                    Grades = input.Skip(1).Select(double.Parse).ToList()
                });
            }
        }

        List<Student> asdsa = new List<Student>();
        asdsa = bestStudents.OrderBy(t => t.Name).ThenByDescending(t => t.AvgGrade).ToList();
        foreach (var student in asdsa)
        {
            Console.WriteLine("{0} -> {1:f2}", student.Name, student.AvgGrade);
        }
    }    
}
