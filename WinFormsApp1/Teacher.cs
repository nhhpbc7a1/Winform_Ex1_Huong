using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    class Teacher : Person   
    {
        public Teacher(string name, string address, string cmnd, DateTime birthday, string email, string id, string phone, string gender) : base(name, address, cmnd, birthday, email, id, phone, gender)
        {

        }
    }
}
