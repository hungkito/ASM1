using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM1.Models
{
    public class Student
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public int Age { get; set; }
    }

    public class StudentMamager
    {
        public static List<Student> GetStudents()
        {
            var Students = new List<Student>();

            Students.Add(new Student { Name = "StudentA", Image = "Assets/female-01.png", Age = 2002 });
            Students.Add(new Student { Name = "StudentB", Image = "Assets/male-01.png", Age = 2002 });
            Students.Add(new Student { Name = "StudentC", Image = "Assets/female-03.png", Age = 2002 });
            return Students;
        }
    }
}
