namespace WinFormsApp1
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblAddressgv = new System.Windows.Forms.Label();
            this.lblCMNDgv = new System.Windows.Forms.Label();
            this.txtNamegv = new System.Windows.Forms.TextBox();
            this.txtAddressgv = new System.Windows.Forms.TextBox();
            this.txtCMNDgv = new System.Windows.Forms.TextBox();
            this.gv = new System.Windows.Forms.DataGridView();
            this.dtBirthdaygv = new System.Windows.Forms.DateTimePicker();
            this.txtBirthdaygv = new System.Windows.Forms.Label();
            this.btnThemgv = new System.Windows.Forms.Button();
            this.btnXoagv = new System.Windows.Forms.Button();
            this.btnSuagv = new System.Windows.Forms.Button();
            this.btnTimkiemgv = new System.Windows.Forms.Button();
            this.lblNamegv = new System.Windows.Forms.Label();
            this.lblEmailgv = new System.Windows.Forms.Label();
            this.lblDgv = new System.Windows.Forms.Label();
            this.lblPhonegv = new System.Windows.Forms.Label();
            this.lblGendergv = new System.Windows.Forms.Label();
            this.txtEmailgv = new System.Windows.Forms.TextBox();
            this.txtIDgv = new System.Windows.Forms.TextBox();
            this.txtPhonegv = new System.Windows.Forms.TextBox();
            this.txtGendergv = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 0;
            // 
            // lblAddressgv
            // 
            this.lblAddressgv.AutoSize = true;
            this.lblAddressgv.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAddressgv.Location = new System.Drawing.Point(24, 82);
            this.lblAddressgv.Name = "lblAddressgv";
            this.lblAddressgv.Size = new System.Drawing.Size(51, 17);
            this.lblAddressgv.TabIndex = 1;
            this.lblAddressgv.Text = "Dia chi";
            // 
            // lblCMNDgv
            // 
            this.lblCMNDgv.AutoSize = true;
            this.lblCMNDgv.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCMNDgv.Location = new System.Drawing.Point(24, 127);
            this.lblCMNDgv.Name = "lblCMNDgv";
            this.lblCMNDgv.Size = new System.Drawing.Size(48, 17);
            this.lblCMNDgv.TabIndex = 2;
            this.lblCMNDgv.Text = "CMND";
            // 
            // txtNamegv
            // 
            this.txtNamegv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtNamegv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNamegv.Location = new System.Drawing.Point(127, 36);
            this.txtNamegv.Name = "txtNamegv";
            this.txtNamegv.Size = new System.Drawing.Size(200, 23);
            this.txtNamegv.TabIndex = 3;
            // 
            // txtAddressgv
            // 
            this.txtAddressgv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtAddressgv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddressgv.Location = new System.Drawing.Point(127, 74);
            this.txtAddressgv.Name = "txtAddressgv";
            this.txtAddressgv.Size = new System.Drawing.Size(200, 23);
            this.txtAddressgv.TabIndex = 4;
            // 
            // txtCMNDgv
            // 
            this.txtCMNDgv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtCMNDgv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCMNDgv.Location = new System.Drawing.Point(127, 119);
            this.txtCMNDgv.Name = "txtCMNDgv";
            this.txtCMNDgv.Size = new System.Drawing.Size(200, 23);
            this.txtCMNDgv.TabIndex = 5;
            // 
            // gv
            // 
            this.gv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv.Location = new System.Drawing.Point(356, 21);
            this.gv.Name = "gv";
            this.gv.RowTemplate.Height = 25;
            this.gv.Size = new System.Drawing.Size(389, 182);
            this.gv.TabIndex = 6;
            this.gv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_CellContentClick_1);
            // 
            // dtBirthdaygv
            // 
            this.dtBirthdaygv.Location = new System.Drawing.Point(127, 169);
            this.dtBirthdaygv.Name = "dtBirthdaygv";
            this.dtBirthdaygv.Size = new System.Drawing.Size(200, 23);
            this.dtBirthdaygv.TabIndex = 7;
            // 
            // txtBirthdaygv
            // 
            this.txtBirthdaygv.AutoSize = true;
            this.txtBirthdaygv.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtBirthdaygv.Location = new System.Drawing.Point(24, 169);
            this.txtBirthdaygv.Name = "txtBirthdaygv";
            this.txtBirthdaygv.Size = new System.Drawing.Size(70, 17);
            this.txtBirthdaygv.TabIndex = 8;
            this.txtBirthdaygv.Text = "Ngay sinh";
            // 
            // btnThemgv
            // 
            this.btnThemgv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnThemgv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemgv.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnThemgv.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnThemgv.Location = new System.Drawing.Point(39, 387);
            this.btnThemgv.Name = "btnThemgv";
            this.btnThemgv.Size = new System.Drawing.Size(75, 23);
            this.btnThemgv.TabIndex = 9;
            this.btnThemgv.Text = "Them";
            this.btnThemgv.UseVisualStyleBackColor = false;
            this.btnThemgv.Click += new System.EventHandler(this.btnThemgv_Click);
            // 
            // btnXoagv
            // 
            this.btnXoagv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnXoagv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoagv.Location = new System.Drawing.Point(223, 387);
            this.btnXoagv.Name = "btnXoagv";
            this.btnXoagv.Size = new System.Drawing.Size(75, 23);
            this.btnXoagv.TabIndex = 10;
            this.btnXoagv.Text = "Xoa";
            this.btnXoagv.UseVisualStyleBackColor = false;
            this.btnXoagv.Click += new System.EventHandler(this.btnXoagv_Click);
            // 
            // btnSuagv
            // 
            this.btnSuagv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSuagv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuagv.Location = new System.Drawing.Point(401, 387);
            this.btnSuagv.Name = "btnSuagv";
            this.btnSuagv.Size = new System.Drawing.Size(75, 23);
            this.btnSuagv.TabIndex = 11;
            this.btnSuagv.Text = "Sua";
            this.btnSuagv.UseVisualStyleBackColor = false;
            this.btnSuagv.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnTimkiemgv
            // 
            this.btnTimkiemgv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnTimkiemgv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimkiemgv.Location = new System.Drawing.Point(602, 387);
            this.btnTimkiemgv.Name = "btnTimkiemgv";
            this.btnTimkiemgv.Size = new System.Drawing.Size(75, 23);
            this.btnTimkiemgv.TabIndex = 12;
            this.btnTimkiemgv.Text = "Tim kiem";
            this.btnTimkiemgv.UseVisualStyleBackColor = false;
            this.btnTimkiemgv.Click += new System.EventHandler(this.btnTimkiemgv_Click);
            // 
            // lblNamegv
            // 
            this.lblNamegv.AutoSize = true;
            this.lblNamegv.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNamegv.Location = new System.Drawing.Point(27, 45);
            this.lblNamegv.Name = "lblNamegv";
            this.lblNamegv.Size = new System.Drawing.Size(68, 17);
            this.lblNamegv.TabIndex = 13;
            this.lblNamegv.Text = "Ho va ten";
            // 
            // lblEmailgv
            // 
            this.lblEmailgv.AutoSize = true;
            this.lblEmailgv.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmailgv.Location = new System.Drawing.Point(27, 214);
            this.lblEmailgv.Name = "lblEmailgv";
            this.lblEmailgv.Size = new System.Drawing.Size(42, 17);
            this.lblEmailgv.TabIndex = 15;
            this.lblEmailgv.Text = "Email";
            // 
            // lblDgv
            // 
            this.lblDgv.AutoSize = true;
            this.lblDgv.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDgv.Location = new System.Drawing.Point(27, 256);
            this.lblDgv.Name = "lblDgv";
            this.lblDgv.Size = new System.Drawing.Size(22, 17);
            this.lblDgv.TabIndex = 16;
            this.lblDgv.Text = "ID";
            // 
            // lblPhonegv
            // 
            this.lblPhonegv.AutoSize = true;
            this.lblPhonegv.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPhonegv.Location = new System.Drawing.Point(27, 296);
            this.lblPhonegv.Name = "lblPhonegv";
            this.lblPhonegv.Size = new System.Drawing.Size(47, 17);
            this.lblPhonegv.TabIndex = 18;
            this.lblPhonegv.Text = "Phone";
            // 
            // lblGendergv
            // 
            this.lblGendergv.AutoSize = true;
            this.lblGendergv.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGendergv.Location = new System.Drawing.Point(27, 338);
            this.lblGendergv.Name = "lblGendergv";
            this.lblGendergv.Size = new System.Drawing.Size(52, 17);
            this.lblGendergv.TabIndex = 19;
            this.lblGendergv.Text = "Gender";
            // 
            // txtEmailgv
            // 
            this.txtEmailgv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtEmailgv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmailgv.Location = new System.Drawing.Point(127, 208);
            this.txtEmailgv.Name = "txtEmailgv";
            this.txtEmailgv.Size = new System.Drawing.Size(100, 23);
            this.txtEmailgv.TabIndex = 20;
            // 
            // txtIDgv
            // 
            this.txtIDgv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtIDgv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDgv.Location = new System.Drawing.Point(127, 250);
            this.txtIDgv.Name = "txtIDgv";
            this.txtIDgv.Size = new System.Drawing.Size(100, 23);
            this.txtIDgv.TabIndex = 21;
            // 
            // txtPhonegv
            // 
            this.txtPhonegv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtPhonegv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhonegv.Location = new System.Drawing.Point(127, 296);
            this.txtPhonegv.Name = "txtPhonegv";
            this.txtPhonegv.Size = new System.Drawing.Size(100, 23);
            this.txtPhonegv.TabIndex = 22;
            // 
            // txtGendergv
            // 
            this.txtGendergv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtGendergv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGendergv.Location = new System.Drawing.Point(127, 338);
            this.txtGendergv.Name = "txtGendergv";
            this.txtGendergv.Size = new System.Drawing.Size(100, 23);
            this.txtGendergv.TabIndex = 23;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.Location = new System.Drawing.Point(356, 250);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(0, 17);
            this.lblEmail.TabIndex = 24;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtGendergv);
            this.Controls.Add(this.txtPhonegv);
            this.Controls.Add(this.txtIDgv);
            this.Controls.Add(this.txtEmailgv);
            this.Controls.Add(this.lblGendergv);
            this.Controls.Add(this.lblPhonegv);
            this.Controls.Add(this.lblDgv);
            this.Controls.Add(this.lblEmailgv);
            this.Controls.Add(this.lblNamegv);
            this.Controls.Add(this.btnTimkiemgv);
            this.Controls.Add(this.btnSuagv);
            this.Controls.Add(this.btnXoagv);
            this.Controls.Add(this.btnThemgv);
            this.Controls.Add(this.txtBirthdaygv);
            this.Controls.Add(this.dtBirthdaygv);
            this.Controls.Add(this.gv);
            this.Controls.Add(this.txtCMNDgv);
            this.Controls.Add(this.txtAddressgv);
            this.Controls.Add(this.txtNamegv);
            this.Controls.Add(this.lblCMNDgv);
            this.Controls.Add(this.lblAddressgv);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lblAddressgv;
        private Label lblCMNDgv;
        private TextBox txtNamegv;
        private TextBox txtAddressgv;
        private TextBox txtCMNDgv;
        private DataGridView gv;
        private DateTimePicker dtBirthdaygv;
        private Label txtBirthdaygv;
        private Button btnThemgv;
        private Button btnXoagv;
        private Button btnSuagv;
        private Button btnTimkiemgv;
        private Label lblNamegv;
        private Label lblEmailgv;
        private Label lblDgv;
        private Label lblPhonegv;
        private Label lblGendergv;
        private TextBox txtEmailgv;
        private TextBox txtIDgv;
        private TextBox txtPhonegv;
        private TextBox txtGendergv;
        private Label lblEmail;
    }
}