using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humans
{
    class CourseWork
    {
        private string _description;
        private Student _student;
        private DateTime _date;

        public CourseWork()
        {
            Description = "Програмування з розподільними змінними. Аналіз сучасних підходів.";
            Student = new Student();
            Date = new DateTime(2022, 9, 20);
        }
        public CourseWork(string description, Student student, DateTime date)
        {
            this._description = description;
            this._student = student;
            this._date = date;
        }

        public void printInfo()
        {
            string data = "Description: " + Description + "\n" +
                "Student: " + Student.inString() + "\n" +
                "Date: " + Date;
            Console.WriteLine(data);
        }

        public string inString()
        {
            return "Description: " + Description + "\n" +
                "Student: " + Student.inString() + "\n" +
                "Date: " + Date;
        }

        public string Description
        {
            get { return _description;  }
            set { _description = value; }
        }
        public Student Student
        {
            get { return _student; }
            set { _student = value; }
        }
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }
    }
}
