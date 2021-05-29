using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sales_Management.PL
{
    public partial class FRM_PRODUCT_LIST : Form
    {
        BL.CLS_PRODUCTS prd = new BL.CLS_PRODUCTS();

        public FRM_PRODUCT_LIST()
        {
            InitializeComponent();
            this.dgvproducts.DataSource = prd.GET_ALL_PRODUCTS();

        }

        private void FRM_PRODUCT_LIST_Load(object sender, EventArgs e)
        {

        }

        private void dgvproducts_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
