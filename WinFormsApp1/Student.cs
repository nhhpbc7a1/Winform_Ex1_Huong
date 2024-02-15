using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    class Student : Person
    {
        private int score = 0;
        public int Score { get { return score; } }
        public Student(string name, string address, string cmnd, DateTime birthday, string email, string id, string phone, string gender, int score) : base(name,address, cmnd, birthday,email,id,phone, gender)
        {
            this.score = score;
        }
       
    }
}
