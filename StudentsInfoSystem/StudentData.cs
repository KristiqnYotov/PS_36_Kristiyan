using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    class StudentData
    {
        public List<Student> TestStudents()
        {
            List<Student> students = new List<Student>();
            Student student = new Student();
            student.Name = "Kristiyan";
            student.SecondName = "Ulianov";
            student.FamilyName = "Yotov";
            student.FacultyNumber = "501219019";
            student.Faculty = "FKST";
            student.Speciality = "ITI";
            student.Status = "Uchesht";
            student.Course = 3;
            student.Flow = 2;
            student.Group = 35;
            student.Step = "Bakalavur";
            students.Add(student);
            return students;
        }
    }
}
