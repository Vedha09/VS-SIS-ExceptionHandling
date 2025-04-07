using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS
{
    internal class SIS
    {
        public Student[] Students { get; set; } = new Student[100];
        public Course[] Courses { get; set; } = new Course[100];
        public Teacher[] Teachers { get; set; } = new Teacher[100];
        public Payment[] Payments { get; set; } = new Payment[100];
        private int studentCount = 0;
        private int courseCount = 0;
        private int teacherCount = 0;
        private int paymentCount = 0;

        public void EnrollStudentInCourse(Student student, Course course)
        {
            student.EnrollInCourse(course);
        }
        public void AssignTeacherToCourse(Teacher teacher, Course course)
        {
            course.AssignTeacher(teacher);
        }
        public void RecordPayment(Student student, decimal amount, DateTime paymentDate)
        {
            student.MakePayment(amount, paymentDate);
        }
        public Enrollment[] GenerateEnrollmentReport(Course course)
        {
            return course.GetEnrollments();
        }
        public Payment[] GeneratePaymentReport(Student student)
        {
            return student.GetPaymentHistory();
        }
    }
}
