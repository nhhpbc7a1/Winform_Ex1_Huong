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
            Teacher teacher = new Teacher(txtNamegv.Text, txtAddressgv.Text, txtCMNDgv.Text, dtBirthdaygv.Value, txtEmailgv.Text, txtIDgv.Text, txtPhonegv.Text, txtGendergv.Text);
            if (txtNamegv.Text.Trim() == "")
            {
                MessageBox.Show("You haven't input your name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNamegv.Focus();
                return;
            }
            if (txtAddressgv.Text.Trim() == "")
            {
                MessageBox.Show("You haven't input your address!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddressgv.Focus();
                return;
            }
            if (txtCMNDgv.Text.Trim() == "")
            {
                MessageBox.Show("You haven't input your CMND!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCMNDgv.Focus();
                return;
            }
            if (txtEmailgv.Text.Trim() == "")
            {
                MessageBox.Show("You haven't input your Email!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmailgv.Focus();
                return;
            }
            if (txtIDgv.Text.Trim() == "")
            {
                MessageBox.Show("You haven't input your ID!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIDgv.Focus();
                return;
            }
            if (txtPhonegv.Text.Trim() == "")
            {
                MessageBox.Show("You haven't input your Phone!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhonegv.Focus();
                return;
            }
            if (txtGendergv.Text.Trim() == "")
            {
                MessageBox.Show("You haven't input your Gender!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGendergv.Focus();
                return;
            }
            if (!(DateTime.Now.Year - 18 > dtBirthdaygv.Value.Year) || (DateTime.Now.Year - 18 == dtBirthdaygv.Value.Year && DateTime.Now.Month > dtBirthdaygv.Value.Month)
               || (DateTime.Now.Year - 18 == dtBirthdaygv.Value.Year && DateTime.Now.Month == dtBirthdaygv.Value.Month && DateTime.Now.Date >= dtBirthdaygv.Value.Date))
            {
                MessageBox.Show("Your birthday is not valid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!teacherDAO.IsValidEmail(txtEmailgv.Text))
            {
                MessageBox.Show(" Your email is not valid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmailgv.Focus();
                return;
            }
            int num = 0;
            if (Int32.TryParse(txtPhonegv.Text, out num) && txtPhonegv.Text.Length == 10)
            {
                txtPhonegv.Text = txtPhonegv.Text.ToString();
            }
            else
            {
                MessageBox.Show("Your phone is not valid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            teacherDAO.Add(teacher);
            Form2_Load(sender, e);

        }

        private void btnXoagv_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher(txtNamegv.Text, txtAddressgv.Text, txtCMNDgv.Text, dtBirthdaygv.Value, txtEmailgv.Text, txtIDgv.Text, txtPhonegv.Text, txtGendergv.Text);
            teacherDAO.Delete(teacher);         
            Form2_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher(txtNamegv.Text, txtAddressgv.Text, txtCMNDgv.Text, dtBirthdaygv.Value, txtEmailgv.Text, txtIDgv.Text, txtPhonegv.Text, txtGendergv.Text);
            if (txtNamegv.Text.Trim() == "")
            {
                MessageBox.Show("You haven't input your name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNamegv.Focus();
                return;
            }
            if (txtAddressgv.Text.Trim() == "")
            {
                MessageBox.Show("You haven't input your address!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddressgv.Focus();
                return;
            }
            if (txtCMNDgv.Text.Trim() == "")
            {
                MessageBox.Show("You haven't input your CMND!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCMNDgv.Focus();
                return;
            }
            if (txtEmailgv.Text.Trim() == "")
            {
                MessageBox.Show("You haven't input your Email!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmailgv.Focus();
                return;
            }
            if (txtIDgv.Text.Trim() == "")
            {
                MessageBox.Show("You haven't input your ID!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIDgv.Focus();
                return;
            }
            if (txtPhonegv.Text.Trim() == "")
            {
                MessageBox.Show("You haven't input your Phone!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhonegv.Focus();
                return;
            }
            if (txtGendergv.Text.Trim() == "")
            {
                MessageBox.Show("You haven't input your Gender!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGendergv.Focus();
                return;
            }
            if (!(DateTime.Now.Year - 18 > dtBirthdaygv.Value.Year) || (DateTime.Now.Year - 18 == dtBirthdaygv.Value.Year && DateTime.Now.Month > dtBirthdaygv.Value.Month)
               || (DateTime.Now.Year - 18 == dtBirthdaygv.Value.Year && DateTime.Now.Month == dtBirthdaygv.Value.Month && DateTime.Now.Date >= dtBirthdaygv.Value.Date))
            {
                MessageBox.Show("Your birthday is not valid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!teacherDAO.IsValidEmail(txtEmailgv.Text))
            {
                MessageBox.Show(" Your email is not valid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmailgv.Focus();
                return;
            }
            int num = 0;
            if (Int32.TryParse(txtPhonegv.Text, out num) && txtPhonegv.Text.Length == 10)
            {
                txtPhonegv.Text = txtPhonegv.Text.ToString();
            }
            else
            {
                MessageBox.Show("Your phone is not valid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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
                txtEmailgv.Text = row.Cells["Email"].Value.ToString();
                txtIDgv.Text = row.Cells["Id"].Value.ToString();
                txtPhonegv.Text = row.Cells["SDT"].Value.ToString();
                txtGendergv.Text = row.Cells["Gender"].Value.ToString();
            }
        }
    }
}
