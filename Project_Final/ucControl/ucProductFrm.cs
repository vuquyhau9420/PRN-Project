using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Final.ucControl
{
    public partial class ucProductFrm : UserControl
    {
        public ucProductFrm()
        {
            InitializeComponent();
        }

        private void ucProductFrm_SizeChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            frmAddEditProduct frmAddEditProduct = new frmAddEditProduct();
            frmAddEditProduct.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmAddEditProduct frmAddEditProduct = new frmAddEditProduct();
            frmAddEditProduct.ShowDialog();
        }
    }
}
