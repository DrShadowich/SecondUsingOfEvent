using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW12
{
    class Family
    {
        private string _name;
        public string Name { get { return _name; } }
        private int _gettedPost;
        public int GettedPost { get { return _gettedPost; } }
        public Family(string name) => _name = name;
        public void GetPost(string post)
        {
            Console.WriteLine($"Семья {Name} получила по почте {post}.");
            _gettedPost++;
        }

    }
}
