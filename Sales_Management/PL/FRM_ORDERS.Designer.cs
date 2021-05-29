namespace Sales_Management.PL
{
    partial class FRM_ORDERS
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtordernotes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbcustomer = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtorder = new System.Windows.Forms.DateTimePicker();
            this.cmbaccount = new System.Windows.Forms.ComboBox();
            this.txtorderid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnnew = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnproduct = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtpriceafterdis = new System.Windows.Forms.TextBox();
            this.txtdiscount = new System.Windows.Forms.TextBox();
            this.txtpricebeforedis = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtnameproduct = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtidproduct = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.txtsum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dgvproduct = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproduct)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtordernotes);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbcustomer);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtorder);
            this.groupBox1.Controls.Add(this.cmbaccount);
            this.groupBox1.Controls.Add(this.txtorderid);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1397, 150);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات الفاتورة";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtordernotes
            // 
            this.txtordernotes.Location = new System.Drawing.Point(721, 116);
            this.txtordernotes.Name = "txtordernotes";
            this.txtordernotes.Size = new System.Drawing.Size(525, 29);
            this.txtordernotes.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1283, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 22);
            this.label6.TabIndex = 9;
            this.label6.Text = "ملاحظات :";
            // 
            // cmbcustomer
            // 
            this.cmbcustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbcustomer.FormattingEnabled = true;
            this.cmbcustomer.Location = new System.Drawing.Point(34, 61);
            this.cmbcustomer.Name = "cmbcustomer";
            this.cmbcustomer.Size = new System.Drawing.Size(249, 30);
            this.cmbcustomer.TabIndex = 8;
            this.cmbcustomer.SelectedIndexChanged += new System.EventHandler(this.cmbcustomer_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(337, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "اسم العميل :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "اسم المحاسب :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1252, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "تاريخ الفاتورة :";
            // 
            // dtorder
            // 
            this.dtorder.Location = new System.Drawing.Point(975, 68);
            this.dtorder.Name = "dtorder";
            this.dtorder.Size = new System.Drawing.Size(271, 29);
            this.dtorder.TabIndex = 4;
            // 
            // cmbaccount
            // 
            this.cmbaccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbaccount.FormattingEnabled = true;
            this.cmbaccount.Location = new System.Drawing.Point(34, 25);
            this.cmbaccount.Name = "cmbaccount";
            this.cmbaccount.Size = new System.Drawing.Size(249, 30);
            this.cmbaccount.TabIndex = 3;
            // 
            // txtorderid
            // 
            this.txtorderid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtorderid.Location = new System.Drawing.Point(1106, 23);
            this.txtorderid.Name = "txtorderid";
            this.txtorderid.ReadOnly = true;
            this.txtorderid.Size = new System.Drawing.Size(140, 29);
            this.txtorderid.TabIndex = 2;
            this.txtorderid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1264, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم الفاتورة :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnnew
            // 
            this.btnnew.Location = new System.Drawing.Point(70, 662);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(119, 39);
            this.btnnew.TabIndex = 1;
            this.btnnew.Text = "فاتورة جديدة";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvproduct);
            this.groupBox2.Controls.Add(this.btnproduct);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtpriceafterdis);
            this.groupBox2.Controls.Add(this.txtdiscount);
            this.groupBox2.Controls.Add(this.txtpricebeforedis);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtqty);
            this.groupBox2.Controls.Add(this.txtprice);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtnameproduct);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtidproduct);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.txtsum);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(26, 200);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1397, 447);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "المنتجات";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnproduct
            // 
            this.btnproduct.Location = new System.Drawing.Point(1210, 60);
            this.btnproduct.Name = "btnproduct";
            this.btnproduct.Size = new System.Drawing.Size(181, 30);
            this.btnproduct.TabIndex = 27;
            this.btnproduct.Text = "قائمة المنتجات";
            this.btnproduct.UseVisualStyleBackColor = true;
            this.btnproduct.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Location = new System.Drawing.Point(1210, 26);
            this.label14.Name = "label14";
            this.label14.Padding = new System.Windows.Forms.Padding(3);
            this.label14.Size = new System.Drawing.Size(181, 36);
            this.label14.TabIndex = 26;
            this.label14.Text = "قائمة المنتجات";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtpriceafterdis
            // 
            this.txtpriceafterdis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpriceafterdis.Location = new System.Drawing.Point(20, 60);
            this.txtpriceafterdis.Name = "txtpriceafterdis";
            this.txtpriceafterdis.ReadOnly = true;
            this.txtpriceafterdis.Size = new System.Drawing.Size(163, 29);
            this.txtpriceafterdis.TabIndex = 24;
            this.txtpriceafterdis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtpriceafterdis.TextChanged += new System.EventHandler(this.txtpriceafterdis_TextChanged);
            // 
            // txtdiscount
            // 
            this.txtdiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdiscount.Location = new System.Drawing.Point(182, 60);
            this.txtdiscount.MaxLength = 3;
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.Size = new System.Drawing.Size(168, 29);
            this.txtdiscount.TabIndex = 23;
            this.txtdiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtdiscount.TextChanged += new System.EventHandler(this.txtdiscount_TextChanged);
            this.txtdiscount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtdiscount_KeyDown);
            this.txtdiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdiscount_KeyPress);
            this.txtdiscount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtdiscount_KeyUp);
            // 
            // txtpricebeforedis
            // 
            this.txtpricebeforedis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpricebeforedis.Location = new System.Drawing.Point(349, 60);
            this.txtpricebeforedis.Name = "txtpricebeforedis";
            this.txtpricebeforedis.ReadOnly = true;
            this.txtpricebeforedis.Size = new System.Drawing.Size(180, 29);
            this.txtpricebeforedis.TabIndex = 22;
            this.txtpricebeforedis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtpricebeforedis.TextChanged += new System.EventHandler(this.txtpricebeforedis_TextChanged);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Location = new System.Drawing.Point(22, 25);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(3);
            this.label13.Size = new System.Drawing.Size(163, 37);
            this.label13.TabIndex = 21;
            this.label13.Text = "الثمن بعد الخصم";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Location = new System.Drawing.Point(184, 25);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(3);
            this.label12.Size = new System.Drawing.Size(168, 36);
            this.label12.TabIndex = 20;
            this.label12.Text = "نسبة الخصم (%)";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Location = new System.Drawing.Point(350, 25);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(3);
            this.label11.Size = new System.Drawing.Size(179, 36);
            this.label11.TabIndex = 19;
            this.label11.Text = "الثمن قبل الخصم";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtqty
            // 
            this.txtqty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtqty.Location = new System.Drawing.Point(527, 60);
            this.txtqty.MaxLength = 8;
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(129, 29);
            this.txtqty.TabIndex = 18;
            this.txtqty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtqty.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            this.txtqty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtqty_KeyDown);
            this.txtqty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtqty_KeyPress);
            this.txtqty.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtqty_KeyUp);
            // 
            // txtprice
            // 
            this.txtprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtprice.Location = new System.Drawing.Point(652, 60);
            this.txtprice.Name = "txtprice";
            this.txtprice.ReadOnly = true;
            this.txtprice.Size = new System.Drawing.Size(129, 29);
            this.txtprice.TabIndex = 17;
            this.txtprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtprice.TextChanged += new System.EventHandler(this.txtprice_TextChanged);
            this.txtprice.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtprice_KeyUp);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Location = new System.Drawing.Point(527, 25);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(3);
            this.label10.Size = new System.Drawing.Size(129, 36);
            this.label10.TabIndex = 16;
            this.label10.Text = "الكمية";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(652, 25);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(3);
            this.label9.Size = new System.Drawing.Size(129, 36);
            this.label9.TabIndex = 15;
            this.label9.Text = "السعر";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtnameproduct
            // 
            this.txtnameproduct.AllowDrop = true;
            this.txtnameproduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnameproduct.Location = new System.Drawing.Point(778, 60);
            this.txtnameproduct.Name = "txtnameproduct";
            this.txtnameproduct.ReadOnly = true;
            this.txtnameproduct.Size = new System.Drawing.Size(310, 29);
            this.txtnameproduct.TabIndex = 14;
            this.txtnameproduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtnameproduct.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Location = new System.Drawing.Point(780, 25);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(3);
            this.label8.Size = new System.Drawing.Size(310, 36);
            this.label8.TabIndex = 13;
            this.label8.Text = "اسم المنتج";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtidproduct
            // 
            this.txtidproduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtidproduct.Location = new System.Drawing.Point(1089, 60);
            this.txtidproduct.Name = "txtidproduct";
            this.txtidproduct.ReadOnly = true;
            this.txtidproduct.Size = new System.Drawing.Size(123, 29);
            this.txtidproduct.TabIndex = 12;
            this.txtidproduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtidproduct.TextChanged += new System.EventHandler(this.txtidproduct_TextChanged);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(1089, 25);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(3);
            this.label7.Size = new System.Drawing.Size(123, 36);
            this.label7.TabIndex = 11;
            this.label7.Text = "رقم المنتج";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1138, 395);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(235, 33);
            this.button5.TabIndex = 10;
            this.button5.Text = "حذف السطر المحدد";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // txtsum
            // 
            this.txtsum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsum.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsum.Location = new System.Drawing.Point(20, 393);
            this.txtsum.Name = "txtsum";
            this.txtsum.ReadOnly = true;
            this.txtsum.Size = new System.Drawing.Size(187, 35);
            this.txtsum.TabIndex = 9;
            this.txtsum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(226, 395);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "المجموع :";
            // 
            // btnsave
            // 
            this.btnsave.Enabled = false;
            this.btnsave.Location = new System.Drawing.Point(215, 662);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(119, 39);
            this.btnsave.TabIndex = 9;
            this.btnsave.Text = "حفظ الفاتورة";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnprint
            // 
            this.btnprint.Enabled = false;
            this.btnprint.Location = new System.Drawing.Point(366, 662);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(131, 39);
            this.btnprint.TabIndex = 9;
            this.btnprint.Text = "طباعة الفاتورة";
            this.btnprint.UseVisualStyleBackColor = true;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(524, 662);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 39);
            this.button4.TabIndex = 9;
            this.button4.Text = "خروج";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dgvproduct
            // 
            this.dgvproduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproduct.Location = new System.Drawing.Point(22, 95);
            this.dgvproduct.Name = "dgvproduct";
            this.dgvproduct.Size = new System.Drawing.Size(1369, 292);
            this.dgvproduct.TabIndex = 28;
            // 
            // FRM_ORDERS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1453, 713);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnnew);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_ORDERS";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشة المبيعات";
            this.Load += new System.EventHandler(this.FRM_ORDERS_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbcustomer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtorder;
        private System.Windows.Forms.ComboBox cmbaccount;
        private System.Windows.Forms.TextBox txtorderid;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtsum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtordernotes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtidproduct;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtnameproduct;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtqty;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtpriceafterdis;
        private System.Windows.Forms.TextBox txtdiscount;
        private System.Windows.Forms.TextBox txtpricebeforedis;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnproduct;
        private System.Windows.Forms.DataGridView dgvproduct;
    }
}