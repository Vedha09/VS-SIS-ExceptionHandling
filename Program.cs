using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace SIS
{
    internal class DuplicateEnrollmentException : ApplicationException
    {
        public DuplicateEnrollmentException(string message) : base(message) { }
    }

    internal class CourseNotFoundException : ApplicationException
    {
        public CourseNotFoundException(string message) : base(message) { }
    }

    internal class StudentNotFoundException : ApplicationException
    {
        public StudentNotFoundException(string message) : base(message) { }
    }

    internal class TeacherNotFoundException : ApplicationException
    {
        public TeacherNotFoundException(string message) : base(message) { }
    }

    internal class PaymentValidationException : ApplicationException
    {
        public PaymentValidationException(string message) : base(message) { }
    }

    internal class InvalidStudentDataException : ApplicationException
    {
        public InvalidStudentDataException(string message) : base(message) { }
    }

    internal class InvalidCourseDataException : ApplicationException
    {
        public InvalidCourseDataException(string message) : base(message) { }
    }

    internal class InvalidEnrollmentDataException : ApplicationException
    {
        public InvalidEnrollmentDataException(string message) : base(message) { }
    }

    internal class InvalidTeacherDataException : ApplicationException
    {
        public InvalidTeacherDataException(string message) : base(message) { }
    }

    internal class InsufficientFundsException : ApplicationException
    {
        public InsufficientFundsException(string message) : base(message) { }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            /*SIS sis = new SIS();
            Student student1 = new Student(101, "Alice", "Ben", "2002-11-08", "Alice.081102@gmail.com", "9123456780");
            Course course1 = new Course(1001, "C# Programming", "C#1001", "John");
            Teacher teacher1 = new Teacher(201, "John", "Hitson", "john.9892@gmail.com", "C#");

            student1.DisplayStudentInfo();
            course1.DisplayCourseInfo();
            teacher1.DisplayTeacherInfo();

            try
            {
                sis.EnrollStudentInCourse(student1, course1);
                sis.EnrollStudentInCourse(student1, course1);
            }

            catch (DuplicateEnrollmentException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }

            try
            {
                sis.RecordPayment(student1, -50, DateTime.Now);
            }

            catch (PaymentValidationException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }*/

            try
            {
                var student = new Student("Alice", "alice@gmail.com", 300);
                var course = new Course("Maths", "MTH101");
                var teacher = new Teacher("Mr.John", "john.990894@gmail.com");

                var enrollment = new Enrollment(student, course);
                enrollment.ProcessEnrollment(100);
                enrollment.ProcessEnrollment(50);
            }

            catch (ApplicationException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}
