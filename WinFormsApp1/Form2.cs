using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        TeacherDAO teacherDAO = new TeacherDAO();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            gv.DataSource = teacherDAO.Load();
        }


        private void btnThemgv_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher(txtNamegv.Text, txtAddressgv.Text, txtCMNDgv.Text, dtBirthdaygv.Value);
            teacherDAO.Add(teacher);
            Form2_Load(sender, e);

        }

        private void btnXoagv_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher(txtNamegv.Text, txtAddressgv.Text, txtCMNDgv.Text, dtBirthdaygv.Value);
            teacherDAO.Delete(teacher);         
            Form2_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher(txtNamegv.Text, txtAddressgv.Text, txtCMNDgv.Text, dtBirthdaygv.Value);
            teacherDAO.Update(teacher);         
            Form2_Load(sender, e);
        }

        private void btnTimkiemgv_Click(object sender, EventArgs e)
        {

        }
        private void gv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void gv_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.gv.Rows[e.RowIndex];
                txtNamegv.Text = row.Cells["Ten"].Value.ToString();
                txtAddressgv.Text = row.Cells["DiaChi"].Value.ToString();
                txtCMNDgv.Text = row.Cells["Cmnd"].Value.ToString();
                dtBirthdaygv.Text = row.Cells["NgaySinh"].Value.ToString();
            }
        }
    }
}
