using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WinFormsApp1
{

    class PersonDAO
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);

        DBConnection dBConnection = new DBConnection();

        public string tableName;
        public PersonDAO() { }
        public DataTable Load()
        {
            string sqlStr = string.Format("SELECT *FROM " + tableName );
            return dBConnection.Load(sqlStr);
        }
        public void Update(Person person)
        {
            string SQL = string.Format(" UPDATE " + tableName + " SET Ten = '{0}', DiaChi = '{1}', Ngaysinh = '{3}', Email = '{4}', Id = '{5}', SDT = '{6}', Gender = '{7}'  WHERE cmnd = '{2}' ;",
            person.Name, person.Address, person.Cmnd, person.Birthday,person.Email, person.Id,person.Phone,person.Gender);

            dBConnection.Execute(SQL);
        }
        public void Add(Person person)
        {
            string sqlStr = string.Format("INSERT INTO " + tableName + "(Ten,Diachi,CMND,NgaySinh,Email,Id,SDT,Gender) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", 
            person.Name, person.Address, person.Cmnd, person.Birthday, person.Email, person.Id, person.Phone, person.Gender);
            dBConnection.Execute(sqlStr);
        }
        public void Delete(Person person)
        {
            string SQL = string.Format("DELETE FROM "+ tableName + " WHERE cmnd = '{0}';", person.Cmnd);
            dBConnection.Execute(SQL);
        }
        //public bool IsEmail(string email)
        //{
        //    if (string.IsNullOrEmpty(email))
        //        return false;

        //    string strRegex = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
        //    Regex regex = new Regex(strRegex);

        //    return regex.IsMatch(email);
        //}
        public bool IsValidEmail(string email)
        {
            var r = new System.Text.RegularExpressions.Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            return !String.IsNullOrEmpty(email) && r.IsMatch(email);
        }
       
    }
}
