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
            this.lblGender = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnHigh = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHs)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvHs
            // 
            this.dtgvHs.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dtgvHs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHs.Location = new System.Drawing.Point(281, 64);
            this.dtgvHs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgvHs.Name = "dtgvHs";
            this.dtgvHs.RowHeadersWidth = 51;
            this.dtgvHs.RowTemplate.Height = 25;
            this.dtgvHs.Size = new System.Drawing.Size(512, 200);
            this.dtgvHs.TabIndex = 0;
            this.dtgvHs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvHs_CellContentClick);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(39, 84);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(87, 23);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Ho va ten";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAddress.Location = new System.Drawing.Point(39, 137);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(65, 23);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "Dia chi";
            // 
            // lblCMND
            // 
            this.lblCMND.AutoSize = true;
            this.lblCMND.BackColor = System.Drawing.Color.Transparent;
            this.lblCMND.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCMND.Location = new System.Drawing.Point(39, 189);
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Size = new System.Drawing.Size(63, 23);
            this.lblCMND.TabIndex = 3;
            this.lblCMND.Text = "CMND";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(128, 80);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(114, 27);
            this.txtName.TabIndex = 4;
            // 
            // txtCMND
            // 
            this.txtCMND.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtCMND.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCMND.Location = new System.Drawing.Point(128, 179);
            this.txtCMND.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(114, 27);
            this.txtCMND.TabIndex = 5;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Location = new System.Drawing.Point(128, 127);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(114, 27);
            this.txtAddress.TabIndex = 6;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Location = new System.Drawing.Point(64, 520);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(86, 31);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Them";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Location = new System.Drawing.Point(448, 520);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(86, 31);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sua";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Location = new System.Drawing.Point(254, 520);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(86, 31);
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
            this.dtBirthday.Location = new System.Drawing.Point(231, 456);
            this.dtBirthday.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtBirthday.Name = "dtBirthday";
            this.dtBirthday.Size = new System.Drawing.Size(228, 27);
            this.dtBirthday.TabIndex = 10;
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.BackColor = System.Drawing.Color.Transparent;
            this.lblBirthday.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBirthday.Location = new System.Drawing.Point(39, 464);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(181, 23);
            this.lblBirthday.TabIndex = 12;
            this.lblBirthday.Text = "Ngày tháng năm sinh";
            // 
            // btnGioavien
            // 
            this.btnGioavien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGioavien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGioavien.Location = new System.Drawing.Point(640, 520);
            this.btnGioavien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGioavien.Name = "btnGioavien";
            this.btnGioavien.Size = new System.Drawing.Size(86, 31);
            this.btnGioavien.TabIndex = 13;
            this.btnGioavien.Text = "Giao vien";
            this.btnGioavien.UseVisualStyleBackColor = false;
            this.btnGioavien.Click += new System.EventHandler(this.btnGioavien_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.Location = new System.Drawing.Point(39, 244);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(54, 23);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "Email";
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblD.Location = new System.Drawing.Point(39, 297);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(28, 23);
            this.lblD.TabIndex = 15;
            this.lblD.Text = "ID";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGender.Location = new System.Drawing.Point(39, 408);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(68, 23);
            this.lblGender.TabIndex = 16;
            this.lblGender.Text = "Gender";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPhone.Location = new System.Drawing.Point(39, 353);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(59, 23);
            this.lblPhone.TabIndex = 17;
            this.lblPhone.Text = "Phone";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Location = new System.Drawing.Point(128, 244);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(114, 27);
            this.txtEmail.TabIndex = 18;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Location = new System.Drawing.Point(128, 293);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(114, 27);
            this.txtID.TabIndex = 19;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Location = new System.Drawing.Point(128, 345);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(114, 27);
            this.txtPhone.TabIndex = 20;
            // 
            // txtGender
            // 
            this.txtGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtGender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGender.Location = new System.Drawing.Point(128, 400);
            this.txtGender.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(114, 27);
            this.txtGender.TabIndex = 21;
            // 
            // txtScore
            // 
            this.txtScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtScore.ForeColor = System.Drawing.Color.Black;
            this.txtScore.Location = new System.Drawing.Point(384, 289);
            this.txtScore.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(114, 27);
            this.txtScore.TabIndex = 23;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblScore.Location = new System.Drawing.Point(291, 293);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(54, 23);
            this.lblScore.TabIndex = 24;
            this.lblScore.Text = "Score";
            // 
            // btnHigh
            // 
            this.btnHigh.Location = new System.Drawing.Point(553, 287);
            this.btnHigh.Name = "btnHigh";
            this.btnHigh.Size = new System.Drawing.Size(94, 29);
            this.btnHigh.TabIndex = 25;
            this.btnHigh.Text = "loaigioi";
            this.btnHigh.UseVisualStyleBackColor = true;
            this.btnHigh.Click += new System.EventHandler(this.btnHigh_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(723, 287);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(94, 29);
            this.btnReload.TabIndex = 26;
            this.btnReload.Text = "reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "giỏi",
            "trung binh, khá",
            "yếu"});
            this.comboBox1.Location = new System.Drawing.Point(553, 344);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 27;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnHigh);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblGender);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private Label lblGender;
        private Label lblPhone;
        private TextBox txtEmail;
        private TextBox txtID;
        private TextBox txtPhone;
        private TextBox txtGender;
        private TextBox txtScore;
        private Label lblScore;
        private Button btnHigh;
        private Button btnReload;
        private ComboBox comboBox1;
    }
}