using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humans
{
    class Student : Human
    {
        private int _group;
        private int _money;

        public Student() : base()
        {
            this._group = 241;
            this._money = 100;
        }
        public Student(string name, string surname, int age, double height,
            double weight, bool habbits, Nation nation, Address address, int group, int money) : base(name, surname,
                age, height, weight, habbits, nation, address)
        {
            this._group = group;
            this._money = money;
        }

        public override void printInfo()
        {
            base.printInfo();
            Console.WriteLine("Група: " + this._group);
            Console.WriteLine("Грошi: " + this._money);
        }

        public int Group
        {
            get { return _group; }
            set { _group = value; }
        }
        public int Money
        {
            get { return _money; }
            set { _money = value; }
        }
    }
}
