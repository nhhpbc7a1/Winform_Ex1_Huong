using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        StudentDAO studentDAO = new StudentDAO();
        DBConnection dBConnection = new DBConnection();

        public Form1()
        {
            InitializeComponent();
            
        }
        public void CheckValid()
        {
            //if (!studentDAO.IsValidEmail(txtEmail.Text))
            //{
            //    MessageBox.Show(" Your email is not valid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtEmail.Focus();
            //    return;
            //}
            if((DateTime.Now.Year - 18 > dtBirthday.Value.Year ) || (DateTime.Now.Year - 18 == dtBirthday.Value.Year && DateTime.Now.Month > dtBirthday.Value.Month)
                ||(DateTime.Now.Year - 18 == dtBirthday.Value.Year && DateTime.Now.Month == dtBirthday.Value.Month && DateTime.Now.Day > dtBirthday.Value.Day))
            {
                MessageBox.Show("Your birthday is not valid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
          
        }
        public void CheckEmptyData()
        {
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("You haven't input your name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return;
            }
            if (txtAddress.Text.Trim() == "")
            {
                MessageBox.Show("You haven't input your address!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddress.Focus();
                return;
            }
            if (txtCMND.Text.Trim() == "")
            {
                MessageBox.Show("You haven't input your CMND!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCMND.Focus();
                return;
            }
            if (txtEmail.Text.Trim() == "")
            {
                MessageBox.Show("You haven't input your Email!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }
            if (txtID.Text.Trim() == "")
            {
                MessageBox.Show("You haven't input your ID!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtID.Focus();
                return;
            }
            if (txtPhone.Text.Trim() == "")
            {
                MessageBox.Show("You haven't input your Phone!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Focus();
                return;
            }
            if (txtGender.Text.Trim() == "")
            {
                MessageBox.Show("You haven't input your Gender!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGender.Focus();
                return;
            }
            if (txtScore.Text.Trim() == "")
            {
                MessageBox.Show("You haven't input your Score!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtScore.Focus();
                return;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtgvHs.DataSource = studentDAO.Load(); /// gvHsinh = name cua data gridview
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int score = 0;
            int.TryParse(txtScore.Text, out score);

            Student student = new Student(txtName.Text, txtAddress.Text, txtCMND.Text, dtBirthday.Value,txtEmail.Text, txtID.Text, txtPhone.Text, txtGender.Text,score);
            
            //CheckEmptyData();

            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("You haven't input your name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return;
            }
            if (txtAddress.Text.Trim() == "")
            {
                MessageBox.Show("You haven't input your address!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddress.Focus();
                return;
            }
            if (txtCMND.Text.Trim() == "")
            {
                MessageBox.Show("You haven't input your CMND!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCMND.Focus();
                return;
            }
            if (txtEmail.Text.Trim() == "")
            {
                MessageBox.Show("You haven't input your Email!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }
            if (txtID.Text.Trim() == "")
            {
                MessageBox.Show("You haven't input your ID!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtID.Focus();
                return;
            }
            if (txtPhone.Text.Trim() == "")
            {
                MessageBox.Show("You haven't input your Phone!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Focus();
                return;
            }
            if (txtGender.Text.Trim() == "")
            {
                MessageBox.Show("You haven't input your Gender!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGender.Focus();
                return;
            }
            if (txtScore.Text.Trim() == "")
            {
                MessageBox.Show("You haven't input your Gender!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtScore.Focus();
                return;
            }
            if (!studentDAO.IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show(" Your email is not valid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }
            int num = 0;
            if (Int32.TryParse(txtPhone.Text, out num) && txtPhone.Text.Length == 10)
            {
                txtPhone.Text = txtPhone.Text.ToString();
            }
            else
            {
                MessageBox.Show("Your phone is not valid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!(DateTime.Now.Year - 18 > dtBirthday.Value.Year)
                || (DateTime.Now.Year - 18 == dtBirthday.Value.Year && DateTime.Now.Month > dtBirthday.Value.Month)
                || (DateTime.Now.Year - 18 == dtBirthday.Value.Year && DateTime.Now.Month == dtBirthday.Value.Month && DateTime.Now.Date >= dtBirthday.Value.Date))
            {
                MessageBox.Show("Your birthday is not valid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sqlStr = string.Format("SELECT *  FROM HocSinh where cmnd = '{0}'", student.Cmnd);
            DataTable x = dBConnection.Load(sqlStr);
            if(x.Rows.Count > 0)
            {
                MessageBox.Show("Your CMND already EXISTS!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            studentDAO.Add2(student);           
            Form1_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int score = 0;
            int.TryParse(txtScore.Text, out score);
            Student student = new Student(txtName.Text, txtAddress.Text, txtCMND.Text, dtBirthday.Value, txtEmail.Text, txtID.Text, txtPhone.Text, txtGender.Text,score);
            //if(txtCMND.Text.Trim() == "")
            //{
            //    MessageBox.Show(" Your CMND doesnt exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            string sqlStr = string.Format("SELECT *  FROM HocSinh where cmnd = '{0}'",student.Cmnd);
            DataTable x = dBConnection.Load(sqlStr);
            if(x.Rows.Count > 0)
            {
                studentDAO.Delete2(student);
                Form1_Load(sender, e);
            }
            else
            {
                MessageBox.Show(" Your CMND doesnt exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int score = 0;
            int.TryParse(txtScore.Text, out score);
            Student student = new Student(txtName.Text, txtAddress.Text, txtCMND.Text, dtBirthday.Value, txtEmail.Text, txtID.Text, txtPhone.Text, txtGender.Text, score);
            //CheckEmptyData();
            
            if (!studentDAO.IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show(" Your email is not valid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("You haven't input your name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return;
            }
            if (txtAddress.Text.Trim() == "")
            {
                MessageBox.Show("You haven't input your address!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddress.Focus();
                return;
            }
            if (txtCMND.Text.Trim() == "")
            {
                MessageBox.Show("You haven't input your CMND!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCMND.Focus();
                return;
            }
            if (txtEmail.Text.Trim() == "")
            {
                MessageBox.Show("You haven't input your Email!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }
            if (txtID.Text.Trim() == "")
            {
                MessageBox.Show("You haven't input your ID!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtID.Focus();
                return;
            }
            if (txtPhone.Text.Trim() == "")
            {
                MessageBox.Show("You haven't input your Phone!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Focus();
                return;
            }
            if (txtGender.Text.Trim() == "")
            {
                MessageBox.Show("You haven't input your Gender!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGender.Focus();
                return;
            }
           
            if (!studentDAO.IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show(" Your email is not valid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }
            int num = 0;
            if (Int32.TryParse(txtPhone.Text, out num) && txtPhone.Text.Length == 10)
            {
                txtPhone.Text = txtPhone.Text.ToString();
            }
            else
            {
                MessageBox.Show("Your phone is not valid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!(DateTime.Now.Year - 18 > dtBirthday.Value.Year) || (DateTime.Now.Year - 18 == dtBirthday.Value.Year && DateTime.Now.Month > dtBirthday.Value.Month)
               || (DateTime.Now.Year - 18 == dtBirthday.Value.Year && DateTime.Now.Month == dtBirthday.Value.Month && DateTime.Now.Date >= dtBirthday.Value.Date))
            {
                MessageBox.Show("Your birthday is not valid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //CheckValid();
            studentDAO.Update2(student);
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
                txtEmail.Text= row.Cells["Email"].Value.ToString();
                txtID.Text = row.Cells["Id"].Value.ToString();
                txtPhone.Text = row.Cells["SDT"].Value.ToString();
                txtGender.Text= row.Cells["Gender"].Value.ToString();
                txtScore.Text = row.Cells["Score"].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dtgvHs.DataSource = studentDAO.Load(); /// gvHsinh = name cua data gridview
        }

        private void btnHigh_Click(object sender, EventArgs e)
        {
            dtgvHs.DataSource = studentDAO.HighScore(); 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
                dtgvHs.DataSource = studentDAO.HighScore();
            else if (comboBox1.SelectedIndex == 1)
                dtgvHs.DataSource = studentDAO.MediumScore();
            else if (comboBox1.SelectedIndex == 2)
                dtgvHs.DataSource = studentDAO.LowScore();

        }
    }
}
