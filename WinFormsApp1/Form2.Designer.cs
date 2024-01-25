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
            this.lblAddressgv.Location = new System.Drawing.Point(24, 82);
            this.lblAddressgv.Name = "lblAddressgv";
            this.lblAddressgv.Size = new System.Drawing.Size(43, 15);
            this.lblAddressgv.TabIndex = 1;
            this.lblAddressgv.Text = "Dia chi";
            // 
            // lblCMNDgv
            // 
            this.lblCMNDgv.AutoSize = true;
            this.lblCMNDgv.Location = new System.Drawing.Point(24, 127);
            this.lblCMNDgv.Name = "lblCMNDgv";
            this.lblCMNDgv.Size = new System.Drawing.Size(43, 15);
            this.lblCMNDgv.TabIndex = 2;
            this.lblCMNDgv.Text = "CMND";
            // 
            // txtNamegv
            // 
            this.txtNamegv.Location = new System.Drawing.Point(127, 36);
            this.txtNamegv.Name = "txtNamegv";
            this.txtNamegv.Size = new System.Drawing.Size(200, 23);
            this.txtNamegv.TabIndex = 3;
            // 
            // txtAddressgv
            // 
            this.txtAddressgv.Location = new System.Drawing.Point(127, 74);
            this.txtAddressgv.Name = "txtAddressgv";
            this.txtAddressgv.Size = new System.Drawing.Size(200, 23);
            this.txtAddressgv.TabIndex = 4;
            // 
            // txtCMNDgv
            // 
            this.txtCMNDgv.Location = new System.Drawing.Point(127, 119);
            this.txtCMNDgv.Name = "txtCMNDgv";
            this.txtCMNDgv.Size = new System.Drawing.Size(200, 23);
            this.txtCMNDgv.TabIndex = 5;
            // 
            // gv
            // 
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
            this.dtBirthdaygv.Location = new System.Drawing.Point(127, 180);
            this.dtBirthdaygv.Name = "dtBirthdaygv";
            this.dtBirthdaygv.Size = new System.Drawing.Size(200, 23);
            this.dtBirthdaygv.TabIndex = 7;
            // 
            // txtBirthdaygv
            // 
            this.txtBirthdaygv.AutoSize = true;
            this.txtBirthdaygv.Location = new System.Drawing.Point(24, 186);
            this.txtBirthdaygv.Name = "txtBirthdaygv";
            this.txtBirthdaygv.Size = new System.Drawing.Size(60, 15);
            this.txtBirthdaygv.TabIndex = 8;
            this.txtBirthdaygv.Text = "Ngay sinh";
            // 
            // btnThemgv
            // 
            this.btnThemgv.Location = new System.Drawing.Point(48, 291);
            this.btnThemgv.Name = "btnThemgv";
            this.btnThemgv.Size = new System.Drawing.Size(75, 23);
            this.btnThemgv.TabIndex = 9;
            this.btnThemgv.Text = "Them";
            this.btnThemgv.UseVisualStyleBackColor = true;
            this.btnThemgv.Click += new System.EventHandler(this.btnThemgv_Click);
            // 
            // btnXoagv
            // 
            this.btnXoagv.Location = new System.Drawing.Point(210, 291);
            this.btnXoagv.Name = "btnXoagv";
            this.btnXoagv.Size = new System.Drawing.Size(75, 23);
            this.btnXoagv.TabIndex = 10;
            this.btnXoagv.Text = "Xoa";
            this.btnXoagv.UseVisualStyleBackColor = true;
            this.btnXoagv.Click += new System.EventHandler(this.btnXoagv_Click);
            // 
            // btnSuagv
            // 
            this.btnSuagv.Location = new System.Drawing.Point(403, 291);
            this.btnSuagv.Name = "btnSuagv";
            this.btnSuagv.Size = new System.Drawing.Size(75, 23);
            this.btnSuagv.TabIndex = 11;
            this.btnSuagv.Text = "Sua";
            this.btnSuagv.UseVisualStyleBackColor = true;
            this.btnSuagv.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnTimkiemgv
            // 
            this.btnTimkiemgv.Location = new System.Drawing.Point(615, 291);
            this.btnTimkiemgv.Name = "btnTimkiemgv";
            this.btnTimkiemgv.Size = new System.Drawing.Size(75, 23);
            this.btnTimkiemgv.TabIndex = 12;
            this.btnTimkiemgv.Text = "Tim kiem";
            this.btnTimkiemgv.UseVisualStyleBackColor = true;
            this.btnTimkiemgv.Click += new System.EventHandler(this.btnTimkiemgv_Click);
            // 
            // lblNamegv
            // 
            this.lblNamegv.AutoSize = true;
            this.lblNamegv.Location = new System.Drawing.Point(27, 45);
            this.lblNamegv.Name = "lblNamegv";
            this.lblNamegv.Size = new System.Drawing.Size(58, 15);
            this.lblNamegv.TabIndex = 13;
            this.lblNamegv.Text = "Ho va ten";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}