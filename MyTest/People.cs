using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTest
{
    class People
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public People(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }
    }
}
