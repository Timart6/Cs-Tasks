using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humans
{
    class ListTeachers
    {
        private List<Teacher> _list;
        public ListTeachers()
        {
            _list = new List<Teacher>();
        }

        public void add(Teacher human)
        {
            _list.Add(human);
        }
        public void show()
        {
            for (int i = 0; i < _list.Count(); i++)
                _list[i].printInfo();
        }
        public List<Teacher> List
        {
            get { return _list; }
            set { _list = value; }
        }
    }
}
