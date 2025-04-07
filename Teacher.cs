using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SIS
{
    internal class Teacher
    {
        public int teacherId;
        public string firstName;
        public string lastName;
        public string email;
        public string name;
        public string expertise;
        public int TeacherID {
            set {
                teacherId = value;
            }
            get {
                return teacherId;
            }
        }
        public string FirstName {
            set {
                firstName = value;
            }
            get {
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
        public string Email {
            set {
                email = value;
            }
            get {
                return email;
            }
        }

        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        public string Expertise
        {
            set
            {
                expertise = value;
            }
            get
            {
                return expertise;
            }
        }
        public Teacher(int teacherId, string firstName, string lastName, string email, string expertise)
        {
            this.teacherId = teacherId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.expertise = expertise;
        }
        
        public void UpdateTeacherInfo(string name, string email, string expertise)
        {
            this.name = name;
            this.email = email;
            this.expertise = expertise;
        }
        public void DisplayTeacherInfo()
        {
            Console.WriteLine($"Teacher ID: {TeacherID}, Teacher Name: {FirstName} {LastName},, Email: {Email}, Expertise: {Expertise}");
        }
        public Course[] GetAssignedCourses()
        {
            return new Course[0];
        }

        public string fullName;

        public string FullName
        {
            set { fullName = value; }
            get { return fullName; }
        }
        
        public Teacher(string fullName, string email)
        {
            if (string.IsNullOrWhiteSpace(fullName) || !Regex.IsMatch(email, @"^\S+@\S+\.\S+$"))
                throw new InvalidTeacherDataException("Invalid teacher name or email.");

            FullName = fullName;
            Email = email;
        }
    }
}
