using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    class TeacherDAO : PersonDAO
    {
        public TeacherDAO() 
        {
            tableName = "GiaoVien"; 
        }

       
    }
}
