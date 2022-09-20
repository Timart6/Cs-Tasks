using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humans
{
    class Teacher : Human
    {
        private int _salary;
        private string _department;
        private ListStudents _list;

        public Teacher() : base()
        {
            _list = new ListStudents();
        }

        public Teacher(string name, string surname, int age, double height,
            double weight, bool habbits, Nation nation, Address address, int salary, string department) : base(name, surname,
                age, height, weight, habbits, nation, address)
        {
            this._salary = salary;
            this._department = department;
            this._list = new ListStudents();
        }

        public void add(Student student)
        {
            _list.add(student);
        }

        public void show()
        {
            _list.show();
        }

        public override void printInfo()
        {
            base.printInfo();
            Console.WriteLine("Salary: " + this._salary);
            Console.WriteLine("Department: " + this._department);
        }

        public int Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }
        public string Department
        {
            get { return _department; }
            set { _department = value; }
        }
        public ListStudents List
        {
            get { return _list; }
            set { _list = value; }
        }
    }
}
