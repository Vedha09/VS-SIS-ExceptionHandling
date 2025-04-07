using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SIS.Program;

namespace SIS
{
    internal class Enrollment
    {
        public int enrollmentId;
        public Student student;
        public Course course;
        public DateTime enrollmentDate;
        public int EnrollmentID { get; set; }
        public Student Student { get; set; }
        public Course Course { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public Enrollment(int enrollmentId, Student student, Course course, DateTime enrollmentDate)
        {
            this.enrollmentId = enrollmentId;
            this.student = student;
            this.course = course;
            this.enrollmentDate = enrollmentDate;
        }
        public Student GetStudent()
        {
            return Student;
        }

        public Course GetCourse()
        {
            return Course;
        }

        public Enrollment(Student student, Course course)
        {
            if (student == null || course == null)
                throw new InvalidEnrollmentDataException("Student or course for enrollment are missed!!");
            Student = student;
            Course = course;
        }

        public void ProcessEnrollment(decimal fee)
        {
            Student.Pay(fee);
            Console.WriteLine($"{Student.FirstName} successfully enrolled in {Course.CourseName}");
        }
    }
}
