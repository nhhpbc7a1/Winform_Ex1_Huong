using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    class DBConnection
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public DBConnection() { }
        public DataTable Load(string sqlStr)
        {
            DataTable dtSinhVien = new DataTable();
            try
            {
                conn.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                adapter.Fill(dtSinhVien);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }
            return dtSinhVien;
        }
        public void Execute(string sqlStr)
        {
            try
            {
                // Ket noi
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("Thanh cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show("That bai" + ex);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
