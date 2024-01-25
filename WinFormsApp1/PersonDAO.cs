using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
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
            string SQL = string.Format(" UPDATE " + tableName+ " SET Ten = '{0}', DiaChi = '{1}',Ngaysinh = '{3}'  WHERE cmnd = '{2}' ;", person.Name, person.Address, person.Id, person.Birthday);
            dBConnection.Execute(SQL);
        }
        public void Add(Person person)
        {
            string sqlStr = string.Format("INSERT INTO " + tableName+ "(Ten , Diachi,CMND, NgaySinh) VALUES ('{0}', '{1}','{2}','{3}')", person.Name, person.Address, person.Id, person.Birthday);

            dBConnection.Execute(sqlStr);
        }
        public void Delete(Person person)
        {
            string SQL = string.Format("DELETE FROM "+ tableName+ " WHERE cmnd = '{0}';", person.Id);
            dBConnection.Execute(SQL);
        }

    }
}
