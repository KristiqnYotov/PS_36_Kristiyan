using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserLogin;

namespace StudentInfoSystem
{
     class StudentValidation
    {
        public Student GetStudentDataByUser(User u)
        {
            StudentData studentData = new StudentData();
            Student student = new Student();
            List<Student> students = studentData.TestStudents();
            foreach (Student s in students)
            {
                if (s.FacultyNumber == u.facultyNumber)
                {
                    student = s;
                    break;
                }
            }
            if (student != null)
            {
                return student;
            }
            else
            {
                throw new Exception("No such student");
            }
        }
    }
}
