using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS
{
    internal class Payment
    {
        public int paymentId;
        public Student student;
        public decimal amount;
        public DateTime paymentDate;

        public int PaymentID { get; set; }
        public Student Student { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }

        public Payment(int paymentId, Student student, decimal amount, DateTime paymentDate)
        {
            this.paymentId = paymentId;
            this.student = student;
            this.amount = amount;
            this.paymentDate = paymentDate;
        }
        public Student GetStudent()
        {
            return Student;
        }
        public decimal GetPaymentAmount()
        {
            return Amount;
        }
        public DateTime GetPaymentDate()
        {
            return PaymentDate;
        }
    }
}
