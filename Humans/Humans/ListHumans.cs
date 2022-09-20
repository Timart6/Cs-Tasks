using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humans
{
    class HumanList
    {
        private List<Human> humanList;

        public HumanList()
        {
            humanList = new List<Human>(); 
        }

        public void add(Human human)
        {
            humanList.Add(human);
        }

        public void show()
        {
            for (int i = 0; i < humanList.Count(); i++)
                humanList[i].printInfo();
        }

        public void show(int a)
        {
            humanList[a].printInfo();
        }

        public void findCountry_Nation(string country, string nation)
        {
            for (int i = 0; i < humanList.Count(); i++)
            {
                if (humanList[i].Address.Country == country && humanList[i].Nation.ToString() == nation)
                    humanList[i].printInfo();
            }
        }

        public void findName(string name)
        {
            bool positive_result = false;
            for (int i = 0; i < humanList.Count(); i++)
            {
                if (humanList[i].Name == name) {
                    humanList[i].printInfo();
                    positive_result = true;
                }
            }
            if (positive_result == false)
                Console.WriteLine("В списку немає людини з таким iм'ям");
        }
        public void change_find_Name(string current_name, string new_name)
        {
            bool positive_result = false;
            for (int i = 0; i < humanList.Count(); i++)
            {
                if(humanList[i].Name == current_name)
                {
                    humanList[i].Name = new_name;
                    humanList[i].printInfo();
                    positive_result = true;
                }
            }
            if (positive_result == false)
                Console.WriteLine("В списку немає людини з таким iм'ям");
        }

        public void findSurname(string surname)
        {
            bool positive_result = false;
            for (int i = 0; i < humanList.Count(); i++)
            {
                if (humanList[i].Surname == surname)
                {
                    humanList[i].printInfo();
                    positive_result = true;
                }
            }
            if (positive_result == false)
                Console.WriteLine("В списку немає людини з таким прiзвищем");
        }
        public void change_find_Surname(string current_surname, string new_surname)
        {
            bool positive_result = false;
            for (int i = 0; i < humanList.Count(); i++)
            {
                if (humanList[i].Surname == current_surname)
                {
                    humanList[i].Surname = new_surname;
                    humanList[i].printInfo();
                    positive_result = true;
                }
            }
            if (positive_result == false)
                Console.WriteLine("В списку немає людини з таким прiзвищем");
        }

        public void findAge(int age)
        {
            for (int i = 0; i < humanList.Count; i++)
            {
                if (humanList[i].Age == age)
                {
                    humanList[i].printInfo();
                }
            }
        }
        public void change_find_Age(int current_age, int new_age)
        {
            for (int i = 0; i < humanList.Count; i++)
            {
                if (humanList[i].Age == current_age)
                {
                    humanList[i].Age = new_age;
                    humanList[i].printInfo();
                }
            }
        }

        public void findAddress(Address address)
        {
            for (int i = 0; i < humanList.Count; i++)
            {
                if (humanList[i].Address == address)
                    humanList[i].printInfo();
            }
        }
        public void change_find_Address(Address current_address, Address new_address)
        {
            for (int i = 0; i < humanList.Count; i++)
            {
                if (humanList[i].Address == current_address)
                {
                    humanList[i].Address = new_address;
                    humanList[i].printInfo();
                }
            }
        }

        public void remove(string name, string surname)
        {
            for (int i = 0; i < humanList.Count; i++)
            {
                if (humanList[i].Name == name && humanList[i].Surname == surname)
                    humanList.RemoveAt(i);
            }
            Console.WriteLine("Видалення пройшло успішно");
        }

        public void sortAge()
        {
            Human temp;
            for (int i = 0; i < humanList.Count; i++)
            {
                for (int j = i+1; j < humanList.Count; j++)
                {
                    if(humanList[i].Age > humanList[j].Age)
                    {
                        temp = humanList[i];
                        humanList[i] = humanList[j];
                        humanList[j] = temp;
                    }
                }
            }
            for (int i = 0; i < humanList.Count; i++)
            {
                humanList[i].printInfo();
            }
        }
        public void sortHeight()
        {
            Human temp;
            for (int i = 0; i < humanList.Count; i++)
            {
                for (int j = i + 1; j < humanList.Count; j++)
                {
                    if (humanList[i].Height > humanList[j].Height)
                    {
                        temp = humanList[i];
                        humanList[i] = humanList[j];
                        humanList[j] = temp;
                    }
                }
            }
            for (int i = 0; i < humanList.Count; i++)
            {
                humanList[i].printInfo();
            }
        }
        public void sortWeight()
        {
            Human temp;
            for (int i = 0; i < humanList.Count; i++)
            {
                for (int j = i + 1; j < humanList.Count; j++)
                {
                    if (humanList[i].Weight > humanList[j].Weight)
                    {
                        temp = humanList[i];
                        humanList[i] = humanList[j];
                        humanList[j] = temp;
                    }
                }
            }
            for (int i = 0; i < humanList.Count; i++)
            {
                humanList[i].printInfo();
            }
        }

        public void averageAge()
        {
            int age = 0;
            for (int i = 0; i < humanList.Count(); i++)
            {
                age += humanList[i].Age;
            }
            if (humanList.Count() != 0)
            {
                float result = age / humanList.Count();
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Список порожній");
            }

        }
    }
}
