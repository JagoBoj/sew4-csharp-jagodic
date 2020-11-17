using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20201021_Delegates
{
    class Person
    {
        public string name;

        public Person(string name)
        {
            this.name = name;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string ZumGeburtstag(string sender)
        {
            return "Alles Gute zum Geburtstag " + name;
        }
        public string ZumNamensTag(string sender)
        {
            return "Alles Gute zum Namenstag " + name;
        }
    }
}
