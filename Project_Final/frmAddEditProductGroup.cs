using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Final
{
    public partial class frmAddEditProductGroup : Form
    {
        public frmAddEditProductGroup()
        {
            InitializeComponent();
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            frmAddEditSupplier frmAddEditSupplier = new frmAddEditSupplier();
            frmAddEditSupplier.ShowDialog();
        }
    }
}
