using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humans
{
    class ListStudents
    {
        private List<Student> _list;
        public ListStudents()
        {
            _list = new List<Student>();
        }

        public void add(Student human)
        {
            _list.Add(human);
        }
        public void show()
        {
            for (int n = 0; n < _list.Count(); n++)
                _list[n].printInfo();
        }
        public List<Student> List
        {
            get { return _list; }
            set { _list = value; }
        }
    }
   
}
