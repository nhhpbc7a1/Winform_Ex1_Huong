namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtgvHs = new System.Windows.Forms.DataGridView();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCMND = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dtBirthday = new System.Windows.Forms.DateTimePicker();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.btnGioavien = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblD = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHs)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvHs
            // 
            this.dtgvHs.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dtgvHs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHs.Location = new System.Drawing.Point(246, 48);
            this.dtgvHs.Name = "dtgvHs";
            this.dtgvHs.RowTemplate.Height = 25;
            this.dtgvHs.Size = new System.Drawing.Size(448, 150);
            this.dtgvHs.TabIndex = 0;
            this.dtgvHs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvHs_CellContentClick);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(34, 63);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(68, 17);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Ho va ten";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAddress.Location = new System.Drawing.Point(34, 103);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(51, 17);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "Dia chi";
            // 
            // lblCMND
            // 
            this.lblCMND.AutoSize = true;
            this.lblCMND.BackColor = System.Drawing.Color.Transparent;
            this.lblCMND.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCMND.Location = new System.Drawing.Point(34, 142);
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Size = new System.Drawing.Size(48, 17);
            this.lblCMND.TabIndex = 3;
            this.lblCMND.Text = "CMND";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(112, 60);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 23);
            this.txtName.TabIndex = 4;
            // 
            // txtCMND
            // 
            this.txtCMND.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtCMND.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCMND.Location = new System.Drawing.Point(112, 134);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(100, 23);
            this.txtCMND.TabIndex = 5;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Location = new System.Drawing.Point(112, 95);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 23);
            this.txtAddress.TabIndex = 6;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Location = new System.Drawing.Point(56, 390);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Them";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Location = new System.Drawing.Point(392, 390);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sua";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Location = new System.Drawing.Point(222, 390);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xoa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dtBirthday
            // 
            this.dtBirthday.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dtBirthday.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dtBirthday.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dtBirthday.Location = new System.Drawing.Point(202, 342);
            this.dtBirthday.Name = "dtBirthday";
            this.dtBirthday.Size = new System.Drawing.Size(200, 23);
            this.dtBirthday.TabIndex = 10;
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.BackColor = System.Drawing.Color.Transparent;
            this.lblBirthday.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBirthday.Location = new System.Drawing.Point(34, 348);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(141, 17);
            this.lblBirthday.TabIndex = 12;
            this.lblBirthday.Text = "Ngày tháng năm sinh";
            // 
            // btnGioavien
            // 
            this.btnGioavien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGioavien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGioavien.Location = new System.Drawing.Point(560, 390);
            this.btnGioavien.Name = "btnGioavien";
            this.btnGioavien.Size = new System.Drawing.Size(75, 23);
            this.btnGioavien.TabIndex = 13;
            this.btnGioavien.Text = "Giao vien";
            this.btnGioavien.UseVisualStyleBackColor = false;
            this.btnGioavien.Click += new System.EventHandler(this.btnGioavien_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(34, 183);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(36, 15);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "Email";
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Location = new System.Drawing.Point(34, 223);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(18, 15);
            this.lblD.TabIndex = 15;
            this.lblD.Text = "ID";
            this.lblD.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "label4";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(112, 183);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 18;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(112, 220);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 19;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(112, 259);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 20;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(112, 300);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 23);
            this.textBox4.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblD);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnGioavien);
            this.Controls.Add(this.lblBirthday);
            this.Controls.Add(this.dtBirthday);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblCMND);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.dtgvHs);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dtgvHs;
        private Label lblName;
        private Label lblAddress;
        private Label lblCMND;
        private TextBox txtName;
        private TextBox txtCMND;
        private TextBox txtAddress;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private DateTimePicker dtBirthday;
        private Label lblBirthday;
        private Button btnGioavien;
        private Label lblEmail;
        private Label lblD;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}