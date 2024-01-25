using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    class Person
    {
        private string name;
        public string Name { get { return name; } }

        private string address;
        public string Address { get { return address; } }

        private string id;
        public string Id { get { return id; } }

        private DateTime birthday;
        public DateTime Birthday { get { return birthday; } }

        public Person(string name, string address, string id, DateTime birthday)
        {
            this.name = name;
            this.address = address;
            this.id = id;
            this.birthday = birthday;
        }
    }
}

