namespace Sales_Management.PL
{
    partial class FRM_PRODUCTS
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
            this.txtidproduct = new System.Windows.Forms.TextBox();
            this.cmbidcateg = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtregistproduct = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.pbox = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.cmbsalesman = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtpriceproduct = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnameproduct = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvproductlist = new System.Windows.Forms.DataGridView();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductlist)).BeginInit();
            this.SuspendLayout();
            // 
            // txtidproduct
            // 
            this.txtidproduct.BackColor = System.Drawing.Color.White;
            this.txtidproduct.Location = new System.Drawing.Point(1156, 82);
            this.txtidproduct.Name = "txtidproduct";
            this.txtidproduct.Size = new System.Drawing.Size(135, 29);
            this.txtidproduct.TabIndex = 0;
            this.txtidproduct.Validated += new System.EventHandler(this.txtidproduct_Validated);
            // 
            // cmbidcateg
            // 
            this.cmbidcateg.FormattingEnabled = true;
            this.cmbidcateg.Location = new System.Drawing.Point(978, 39);
            this.cmbidcateg.Name = "cmbidcateg";
            this.cmbidcateg.Size = new System.Drawing.Size(313, 30);
            this.cmbidcateg.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btncancel);
            this.groupBox1.Controls.Add(this.btnedit);
            this.groupBox1.Controls.Add(this.btndelete);
            this.groupBox1.Controls.Add(this.btnadd);
            this.groupBox1.Controls.Add(this.btnnew);
            this.groupBox1.Location = new System.Drawing.Point(12, 371);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1173, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "العمليات المتاحة";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(111, 41);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(117, 39);
            this.btncancel.TabIndex = 15;
            this.btncancel.Text = "خروج";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnedit
            // 
            this.btnedit.Enabled = false;
            this.btnedit.Location = new System.Drawing.Point(401, 41);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(161, 39);
            this.btnedit.TabIndex = 15;
            this.btnedit.Text = "تعديل";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btndelete
            // 
            this.btndelete.Enabled = false;
            this.btndelete.Location = new System.Drawing.Point(565, 41);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(173, 39);
            this.btndelete.TabIndex = 15;
            this.btndelete.Text = "حذف";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnadd
            // 
            this.btnadd.Enabled = false;
            this.btnadd.Location = new System.Drawing.Point(744, 41);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(171, 39);
            this.btnadd.TabIndex = 15;
            this.btnadd.Text = "اضافة";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnnew
            // 
            this.btnnew.Location = new System.Drawing.Point(919, 41);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(152, 39);
            this.btnnew.TabIndex = 14;
            this.btnnew.Text = "جديد";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.dtregistproduct);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.pbox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.button9);
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.cmbsalesman);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtpriceproduct);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtqty);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtnameproduct);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtidproduct);
            this.groupBox2.Controls.Add(this.cmbidcateg);
            this.groupBox2.Location = new System.Drawing.Point(12, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1448, 320);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "بيانات المنتجات";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 277);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(284, 22);
            this.label11.TabIndex = 24;
            this.label11.Text = "قم بالضغط على الصورة لاختيار ملف الصورة";
            // 
            // dtregistproduct
            // 
            this.dtregistproduct.Location = new System.Drawing.Point(498, 89);
            this.dtregistproduct.Name = "dtregistproduct";
            this.dtregistproduct.Size = new System.Drawing.Size(313, 29);
            this.dtregistproduct.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(840, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 22);
            this.label10.TabIndex = 22;
            this.label10.Text = "تاريخ التسجيل :";
            // 
            // pbox
            // 
            this.pbox.BackColor = System.Drawing.Color.White;
            this.pbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbox.Location = new System.Drawing.Point(53, 50);
            this.pbox.Name = "pbox";
            this.pbox.Size = new System.Drawing.Size(194, 205);
            this.pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox.TabIndex = 21;
            this.pbox.TabStop = false;
            this.pbox.Click += new System.EventHandler(this.pbox_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(96, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 22);
            this.label9.TabIndex = 20;
            this.label9.Text = "صورة المنتج :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1194, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 22);
            this.label7.TabIndex = 19;
            this.label7.Text = "label7";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(1036, 260);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(69, 39);
            this.button9.TabIndex = 18;
            this.button9.Text = "الاخير";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(1121, 260);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(69, 39);
            this.button8.TabIndex = 17;
            this.button8.Text = "التالى";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1257, 260);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(69, 39);
            this.button7.TabIndex = 16;
            this.button7.Text = "السابق";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1342, 260);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(69, 39);
            this.button6.TabIndex = 15;
            this.button6.Text = "الاول";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // cmbsalesman
            // 
            this.cmbsalesman.FormattingEnabled = true;
            this.cmbsalesman.Location = new System.Drawing.Point(498, 42);
            this.cmbsalesman.Name = "cmbsalesman";
            this.cmbsalesman.Size = new System.Drawing.Size(313, 30);
            this.cmbsalesman.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(830, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "مسئول المبيعات :";
            // 
            // txtpriceproduct
            // 
            this.txtpriceproduct.BackColor = System.Drawing.Color.White;
            this.txtpriceproduct.Location = new System.Drawing.Point(676, 178);
            this.txtpriceproduct.Name = "txtpriceproduct";
            this.txtpriceproduct.Size = new System.Drawing.Size(135, 29);
            this.txtpriceproduct.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(892, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "السعر :";
            // 
            // txtqty
            // 
            this.txtqty.BackColor = System.Drawing.Color.White;
            this.txtqty.Location = new System.Drawing.Point(1156, 182);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(135, 29);
            this.txtqty.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1307, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "الكمية المخزنة :";
            // 
            // txtnameproduct
            // 
            this.txtnameproduct.BackColor = System.Drawing.Color.White;
            this.txtnameproduct.Location = new System.Drawing.Point(978, 132);
            this.txtnameproduct.Name = "txtnameproduct";
            this.txtnameproduct.Size = new System.Drawing.Size(313, 29);
            this.txtnameproduct.TabIndex = 7;
            this.txtnameproduct.Validated += new System.EventHandler(this.txtnameproduct_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1330, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "اسم المنتج :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1332, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "رقم المنتج :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1353, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "الصنف :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvproductlist);
            this.groupBox3.Controls.Add(this.btnsearch);
            this.groupBox3.Controls.Add(this.txtsearch);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(12, 477);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1448, 473);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "قائمة جميع المنتجات";
            // 
            // dgvproductlist
            // 
            this.dgvproductlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvproductlist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvproductlist.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvproductlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproductlist.Location = new System.Drawing.Point(17, 75);
            this.dgvproductlist.Name = "dgvproductlist";
            this.dgvproductlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvproductlist.Size = new System.Drawing.Size(1405, 318);
            this.dgvproductlist.TabIndex = 21;
            this.dgvproductlist.DoubleClick += new System.EventHandler(this.dgvproductlist_DoubleClick_1);
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(944, 33);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(69, 30);
            this.btnsearch.TabIndex = 20;
            this.btnsearch.Text = "موافق";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.button10_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.BackColor = System.Drawing.Color.White;
            this.txtsearch.Location = new System.Drawing.Point(1033, 34);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(313, 29);
            this.txtsearch.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1352, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 22);
            this.label8.TabIndex = 20;
            this.label8.Text = "ابحث هنا :";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(234, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 39);
            this.button1.TabIndex = 16;
            this.button1.Text = "طباعة";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FRM_PRODUCTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1496, 882);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_PRODUCTS";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشة إدارة المنتجات";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductlist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtidproduct;
        public System.Windows.Forms.ComboBox cmbidcateg;
        public System.Windows.Forms.ComboBox cmbsalesman;
        public System.Windows.Forms.TextBox txtpriceproduct;
        public System.Windows.Forms.TextBox txtqty;
        public System.Windows.Forms.TextBox txtnameproduct;
        public System.Windows.Forms.DateTimePicker dtregistproduct;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvproductlist;
        private System.Windows.Forms.Button button1;
    }
}