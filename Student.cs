using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SIS
{
    internal class Student
    {
        public int studentId;
        public string firstName;
        public string lastName;
        public string dateOfBirth;
        public string email;
        public string phoneNumber;    
        public int StudentID {
            set {
                studentId = value;
            }
            get {
                return studentId;
            }
        }
        public string FirstName {
            set {
                firstName = value;
            }
            get
            {
                return firstName;
            }
        }
        public string LastName {
            set {
                lastName = value;
            }
            get {
                return lastName;
            }
        }
        public string DateOfBirth {
            set {
                dateOfBirth = value;
            }
            get {
                return dateOfBirth;
            }
        }
        public string Email {
            set {
                email = value;
            }
            get {
                return email;
            }
        }
        public string PhoneNumber {
            set {
                phoneNumber = value;
            }
            get {
                return phoneNumber;
            }
        }
        public Enrollment[] Enrollments { get; set; } = new Enrollment[100];
        public Payment[] Payments { get; set; } = new Payment[100];
        private int enrollmentCount = 0;
        private int paymentCount = 0;

        public Student(int studentId, string firstName, string lastName, string dateOfBirth, string email, string phoneNumber)
        {
            this.studentId = studentId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfBirth = dateOfBirth;
            this.email = email;
            this.phoneNumber = phoneNumber;
        }

        public decimal balance;

        public decimal Balance
        {
            set { balance = value; }
            get { return balance; }
        }

        public void EnrollInCourse(Course course)
        {
            Enrollment enrollment = new Enrollment(enrollmentCount, this, course, DateTime.Now);
            Enrollments[enrollmentCount++] = enrollment;
            course.AddEnrollment(enrollment);
        }
        public void MakePayment(decimal amount, DateTime paymentDate)
        {
            Payment payment = new Payment(paymentCount, this, amount, paymentDate);
            Payments[paymentCount++] = payment;
        }
        public void DisplayStudentInfo()
        {
            Console.WriteLine($"Student ID: {StudentID}, Student Name: {FirstName} {LastName}, Date of Birth: {DateOfBirth}, Email: {Email}, Phone: {PhoneNumber}");
        }
        public Course[] GetEnrolledCourses()
        {
            Course[] courses = new Course[enrollmentCount];
            for (int i = 0; i < enrollmentCount; i++)
            {
                courses[i] = Enrollments[i].Course;
            }
            return courses;
        }
        public Payment[] GetPaymentHistory()
        {
            Payment[] payments = new Payment[paymentCount];
            for (int i = 0; i < paymentCount; i++)
            {
                payments[i] = Payments[i];
            }
            return payments;
        }

        public Student(string firstName, string email, decimal balance)
        {
            if (string.IsNullOrWhiteSpace(firstName) || !Regex.IsMatch(email, @"^\S+@\S+\.\S+$"))
                throw new InvalidStudentDataException("Invalid student name or email.");
            FirstName = firstName;
            Email = email;
            Balance = balance;
        }
        public void Pay(decimal amount)
        {
            if (amount > Balance)
                throw new InsufficientFundsException("Not enough funds to complete the payment.");
            Balance -= amount;
            Console.WriteLine($"Payment of {amount:C} successful. Remaining balance: {Balance:C}");
        }
    }
}
