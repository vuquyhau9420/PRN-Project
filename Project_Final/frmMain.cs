using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_Final.ucControl;

namespace Project_Final {
    public partial class frmMain : Form {

        ucProductFrm ucProductFrm = null;

        public frmMain() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            //Add product form
            //Hide button when user haven't logged in yet
            btnProductDetais.Hide();
            button3.Hide();
            button4.Hide();
        }
        private void EnabledFunctionForSpecificRole(string role) {
            btnProductDetais.Show();
            button3.Show();
            button4.Show();

            ucProductFrm = new ucProductFrm();
            ucProductFrm.Size = ContentPanel.Size;
            ucProductFrm.Dock = DockStyle.Top;
            ContentPanel.Controls.Add(ucProductFrm);

            if (role.Equals("O"))//Owner
            {
            }
            else if (role.Equals("A"))//Admin
           {
                btnProductDetais.Enabled = false;
            }
            else if (role.Equals("S"))//Staff
           {
                btnProductDetais.Enabled = false;
                button3.Enabled = false;
            }
            btnLogin.Hide();
        }
        private void btnLogin_Click(object sender, EventArgs e) {
            using (var frmLogin = new frmLogin()) {
                frmLogin.ShowDialog();

                string role = frmLogin.Role; // return the role number from frmLogin
                EnabledFunctionForSpecificRole(role);
            }
        }

        private void ContentPanel_SizeChanged(object sender, EventArgs e) {
            if (ucProductFrm != null) {
                ucProductFrm.Size = ContentPanel.Size;
            }
        }
    }
}
