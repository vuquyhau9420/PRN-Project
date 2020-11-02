using Project_Final.ucControl;
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
    public partial class frmProductDetails : Form
    {
        ucProductFrm ucProductFrm = new ucProductFrm();
        public frmProductDetails()
        {
            InitializeComponent();
        }

        private void frmProductDetails_Load(object sender, EventArgs e)
        {
            contentPanel.Controls.Add(ucProductFrm);
        }

        private void contentPanel_SizeChanged(object sender, EventArgs e)
        {
            ucProductFrm.Size = contentPanel.Size;
        }
    }
}
