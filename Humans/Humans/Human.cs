using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humans
{
    enum Nation { Ukrainian, French, Polish };
    class Human
    {
        protected string _name;
        protected string _surname;
        protected int _age;
        protected double _height;
        protected double _weight;
        protected bool _habbits;
        protected Nation _nation;
        protected Address _address;

        public Human()
        {
            this._name = "Timophiy";
            this._surname = "Averjanov";
            this._age = 18;
            this._height = 1.75;
            this._weight = 60;
            this._habbits = false;
            this._nation = Nation.Ukrainian;
            this._address = new Address();
        }

        public Human(string name, string surname, int age, double height, double weight, bool habbits, Nation nation, Address address)
        {
            this._name = name;
            this._surname = surname;
            this._age = age;
            this._height = height;
            this._weight = weight;
            this._habbits = habbits;
            this._nation = nation;
            this._address = address;
        }

        public static Human operator +(Human one, Human two)
        {
            Human result = new Human();
            result._age = one._age + two._age;
            result._habbits = one._habbits && two._habbits;
            return result;
        }

        public static bool operator >(Human one, Human two)
        {
            bool result = one._age > two._age;
            return result;
        }

        public static bool operator <(Human one, Human two)
        {
            bool result = one._age < two._age;
            return result;
        }

        public virtual void printInfo()
        {
            string data =
                "Name: " + this._name + "\n" +
                "Surname: " + this._surname + "\n" +
                "Age: " + this._age.ToString() + "\n" +
                "Height: " + this._height.ToString() + "\n" +
                "Weight: " + this._weight.ToString() + "\n" +
                "Is Habbits: " + this._habbits.ToString() + "\n" +
                "Nation: " + this._nation.ToString() + "\n" +
                "Address: " + this._address.inString();
                Console.WriteLine(data);
        }

        public string inString()
        {
            return "Name: " + this._name + "\n" +
                "Surname: " + this._surname + "\n" +
                "Age: " + this._age.ToString() + "\n" +
                "Height: " + this._height.ToString() + "\n" +
                "Weight: " + this._weight.ToString() + "\n" +
                "Is Habbits: " + this._habbits.ToString() + "\n" +
                "Nation: " + this._nation.ToString() + "\n" +
                "Address: " + this._address.inString();
        }

        public static Human inputHuman()
        {
            Console.WriteLine("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Surname: ");
            string surname = Console.ReadLine();
            Console.WriteLine("Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Height: ");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("Weight: ");
            double weight = double.Parse(Console.ReadLine());
            Console.WriteLine("Habbits: ");
            bool habbits = bool.Parse(Console.ReadLine());
            Console.WriteLine("Nation: ");
            Nation nation = (Nation)Enum.Parse(typeof(Nation), Console.ReadLine(), true);
            Address adr = new Address();
            Human n = new Human(name, surname, age, height, weight, habbits, nation, adr.inputAddress());
            return n;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public double Height
        {
            get { return _height; }
            set { _height = value; }
        }

        public double Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        public bool Habbits
        {
            get { return _habbits; }
            set { _habbits = value; }
        }

        public Nation Nation
        {
            get { return _nation; }
            set { _nation = value; }
        }

        public Address Address
        {
            get { return _address; }
            set { _address = value; }
        }
    }
}
