using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Program
    {
        static void printStudents(Student[] students) {
            foreach (var s in students) { 
                s.Show();
            }
        }
        static Student[] getAll() {
            Student[] students = new Student[5];   
            float[] cgpas = new float[] { 3.45f, 2.34f, 3.76f, 3.78f, 3.10f };
            for (int i = 1; i <= 5; i++) {
                students[i] = new Student()
                {
                    Id = i,
                    Name = "Student " + i,
                    Cgpa = cgpas[i],
                };
                
            }
            return students;


        }
        static void Main(string[] args)
        {
            var data = getAll();
            var filtered = (from s in data where s.Cgpa >= 3.75 select s).ToList();
        }
    }
}
