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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        StudentDAO studentDAO = new StudentDAO();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtgvHs.DataSource = studentDAO.Load(); /// gvHsinh = name cua data gridview

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Student student = new Student(txtName.Text, txtAddress.Text, txtCMND.Text, dtBirthday.Value);
            studentDAO.Add(student);
            Form1_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Student student = new Student(txtName.Text, txtAddress.Text, txtCMND.Text, dtBirthday.Value);
            studentDAO.Delete(student);
            Form1_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Student student = new Student(txtName.Text, txtAddress.Text, txtCMND.Text, dtBirthday.Value);
            studentDAO.Update(student);
            Form1_Load(sender, e);

        }


        private void btnGioavien_Click(object sender, EventArgs e)
        {
            Form2 Form= new Form2();
            Form.ShowDialog();
        }

       
        private void dtgvHs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgvHs.Rows[e.RowIndex];
                txtName.Text = row.Cells["Ten"].Value.ToString();
                txtAddress.Text = row.Cells["DiaChi"].Value.ToString();
                txtCMND.Text = row.Cells["Cmnd"].Value.ToString();
                dtBirthday.Text = row.Cells["NgaySinh"].Value.ToString();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
