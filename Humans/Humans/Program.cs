using System;

namespace Humans
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher("Tamara", "Oleksiivna", 49, 1.7, 56.2, false, Nation.French, new Address(), 8000, "KDU");
            Human human1 = new Human();
            Student student1 = new Student("Milush", "Kulpiev", 18, 182.3, 72, false, Nation.Ukrainian, new Address(), 231, 10000000);
            Student student2 = new Student("Bogdan", "Zhovnirchuck", 16, 170, 90, true, Nation.Ukrainian, new Address(), 282, 10);
            teacher.add(student1);
            teacher.add(student2);
            teacher.show();
        }
    }
}
