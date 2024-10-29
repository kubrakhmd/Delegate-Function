using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Function
{
    internal class Exam
    {
        public string Subject { get; set; }
        public TimeSpan ExamDuration { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public Exam(string subject, TimeSpan examDuration, DateTime startDate)
        {
            Subject = subject;
            ExamDuration = examDuration;
            StartDate = startDate;
            EndDate = StartDate.Add(ExamDuration);
        }
    }
}
