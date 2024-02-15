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

        private string cmnd;
        public string Cmnd { get { return cmnd; } }

        private DateTime birthday;
        public DateTime Birthday { get { return birthday; } }

        private string email;
        public string Email { get { return email; } }

        private string id;
        public string Id { get { return id; } }

        private string phone;
        public string Phone { get { return phone; } }

        private string gender;
        public string Gender { get { return gender; } }
        public Person(string name, string address, string cmnd, DateTime birthday, string email, string id, string phone, string gender)
        {
            this.name = name;
            this.address = address;
            this.cmnd = cmnd;
            this.birthday = birthday;
            this.email = email;
            this.id = id;
            this.phone = phone;
            this.gender = gender;
        }
    }
}

