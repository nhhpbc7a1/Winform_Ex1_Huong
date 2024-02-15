using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WinFormsApp1
{
    class StudentDAO : PersonDAO
    {
        DBConnection dBConnection = new DBConnection();

        public StudentDAO()
        {
            tableName = "HocSinh";
        }
        public void Add2(Student student)
        {
            string sqlStr = string.Format("INSERT INTO " + tableName + "(Ten,Diachi,CMND,NgaySinh,Email,Id,SDT,Gender,Score) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')",
            student.Name, student.Address, student.Cmnd, student.Birthday, student.Email, student.Id, student.Phone, student.Gender,student.Score);
            dBConnection.Execute(sqlStr);
        }
        public void Update2(Student student)
        {
            string SQL = string.Format(" UPDATE " + tableName + " SET Ten = '{0}', DiaChi = '{1}', Ngaysinh = '{3}', Email = '{4}', Id = '{5}', SDT = '{6}', Gender = '{7}', Score = '{8}'  WHERE cmnd = '{2}' ",
            student.Name, student.Address, student.Cmnd, student.Birthday, student.Email, student.Id, student.Phone, student.Gender,student.Score);
            dBConnection.Execute(SQL);
        }
        public void Delete2(Student student)
        {
            string SQL = string.Format("DELETE FROM " + tableName + " WHERE cmnd = '{0}';", student.Cmnd);
            dBConnection.Execute(SQL);
        }
        public DataTable HighScore()
        {
            string sqlStr = string.Format("SELECT *FROM Hocsinh where score >= 8");
            return dBConnection.Load(sqlStr);
        }
        public DataTable MediumScore()
        {
            string sqlStr = string.Format("SELECT *FROM Hocsinh where score >=5 and score < 8");
            return dBConnection.Load(sqlStr);
        }
        public DataTable LowScore()
        {
            string sqlStr = string.Format("SELECT *FROM Hocsinh where score < 5");
            return dBConnection.Load(sqlStr);
        }
    }
}
