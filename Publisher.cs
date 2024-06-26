using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW12
{
    delegate void Post(string postName);
    class Publisher
    {
        public event Post PostEvent = null;
        private string _name;
        public string Name { get { return _name; } }
        public Publisher(string name) => _name = name;
        public void SendPost(string name)
        {
            // Как избавиться от подобной ситуации?
            name = _name;
            if (PostEvent != null) PostEvent(name);
        }
    }
}
