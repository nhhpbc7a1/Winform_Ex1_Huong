using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WinFormsApp1
{
    class StudentDAO : PersonDAO
    {
       
        public StudentDAO()
        {
            tableName = "HocSinh";
        }
     
        
    }  
}
