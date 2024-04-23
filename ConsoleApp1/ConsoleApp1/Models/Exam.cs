using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Exam
    {
        private string _subject;
        private int _examDuration;
        public DateTime DateStartDate { get; set; }
        public DateTime DateEndDate { get; set; }
        public string Subject
        {
            get => _subject;
            set
            {
                if (value.Length < 128)
                {
                    _subject = value;
                }
            }
        }

        public int ExamDuration
        {
            get => _examDuration;
            set
            {
                if (value > 0)
                {
                    _examDuration = value;
                }
            }
        }

        public void Start(string subject, int duration)
        {
            Subject = subject;
            ExamDuration = duration;
            DateStartDate = DateTime.Now;
            DateEndDate = DateStartDate.AddMinutes(ExamDuration);
        }

        public static void ShowLastWeek(List<Exam> exams)
        {
            DateTime lastweek = DateTime.Now.AddDays(-7);
            List<Exam> examsLastWeek = new List<Exam>();

            foreach (var exam in exams)
            {
                if (exam.DateStartDate >= lastweek)
                {
                    examsLastWeek.Add(exam);
                }
            }

            Console.WriteLine("Last Week exams");
            foreach (var exam in examsLastWeek)
            {
                Console.WriteLine($"{exam.Subject}");
            }
        }

        public static void CheckLength(List<Exam> exams)
        {
            foreach (var exam in exams)
            {
                if (exam.ExamDuration > 120)
                {
                    Console.WriteLine($"{exam.Subject} length more than 2 hours");
                }
            }
        }

        public static void StillContinue(List<Exam> exams)
        {
            foreach (var exam in exams)
            {
                if (DateTime.Now < exam.DateEndDate)
                {
                    Console.WriteLine($"{exam.Subject} Still continue");
                }
            }
        }

        public static void GetInfo(List<Exam> exams)
        {
            foreach (var exam in exams)
            {
                Console.WriteLine(exam.Subject + " " + exam.ExamDuration + " min");
            }
        }
    }
}
