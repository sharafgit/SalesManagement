namespace Sales_Management.PL
{
    partial class FRM_CONFIG
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
            this.txtserver = new System.Windows.Forms.TextBox();
            this.txtdatabase = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbwindows = new System.Windows.Forms.RadioButton();
            this.rbsql = new System.Windows.Forms.RadioButton();
            this.txtpwd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم السيرفر";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtserver
            // 
            this.txtserver.Location = new System.Drawing.Point(121, 37);
            this.txtserver.Name = "txtserver";
            this.txtserver.Size = new System.Drawing.Size(293, 29);
            this.txtserver.TabIndex = 1;
            this.txtserver.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtdatabase
            // 
            this.txtdatabase.Location = new System.Drawing.Point(121, 98);
            this.txtdatabase.Name = "txtdatabase";
            this.txtdatabase.Size = new System.Drawing.Size(293, 29);
            this.txtdatabase.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "قاعدة البيانات";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "طريقة الدخول";
            // 
            // rbwindows
            // 
            this.rbwindows.AutoSize = true;
            this.rbwindows.Checked = true;
            this.rbwindows.Location = new System.Drawing.Point(187, 160);
            this.rbwindows.Name = "rbwindows";
            this.rbwindows.Size = new System.Drawing.Size(227, 26);
            this.rbwindows.TabIndex = 5;
            this.rbwindows.TabStop = true;
            this.rbwindows.Text = "Windows Authentication";
            this.rbwindows.UseVisualStyleBackColor = true;
            this.rbwindows.CheckedChanged += new System.EventHandler(this.rbwindows_CheckedChanged);
            // 
            // rbsql
            // 
            this.rbsql.AutoSize = true;
            this.rbsql.Location = new System.Drawing.Point(187, 192);
            this.rbsql.Name = "rbsql";
            this.rbsql.Size = new System.Drawing.Size(247, 26);
            this.rbsql.TabIndex = 6;
            this.rbsql.Text = "SQL Server Authentication";
            this.rbsql.UseVisualStyleBackColor = true;
            this.rbsql.CheckedChanged += new System.EventHandler(this.rbsql_CheckedChanged);
            // 
            // txtpwd
            // 
            this.txtpwd.Location = new System.Drawing.Point(143, 303);
            this.txtpwd.Name = "txtpwd";
            this.txtpwd.PasswordChar = '*';
            this.txtpwd.ReadOnly = true;
            this.txtpwd.Size = new System.Drawing.Size(271, 29);
            this.txtpwd.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "كلمة المرور";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(143, 242);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(271, 29);
            this.txtid.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "اسم المستخدم";
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(152, 365);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(128, 34);
            this.btnsave.TabIndex = 11;
            this.btnsave.Text = "حفظ الاعدادات";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(286, 365);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(128, 34);
            this.btncancel.TabIndex = 12;
            this.btncancel.Text = "خروج";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // FRM_CONFIG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(474, 488);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtpwd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rbsql);
            this.Controls.Add(this.rbwindows);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtdatabase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtserver);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FRM_CONFIG";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشة التحكم فى اعدادات الاتصال بالسيرفر";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtserver;
        private System.Windows.Forms.TextBox txtdatabase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbwindows;
        private System.Windows.Forms.RadioButton rbsql;
        private System.Windows.Forms.TextBox txtpwd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btncancel;
    }
}