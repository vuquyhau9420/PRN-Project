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

        ucProductMainFrm ucProductMainFrm = null;

        public frmMain() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            //Add product form
            //Hide button when user haven't logged in yet
        }
        private void EnabledFunctionForSpecificRole(string role) {
            btnProductFrm.Show();
            btnCustomerFrm.Show();
            btnPOSFrm.Show();

            ucProductMainFrm = new ucProductMainFrm();
            ucProductMainFrm.Size = ContentPanel.Size;
            ContentPanel.Controls.Add(ucProductMainFrm);

            if (role.Equals("O"))//Owner
            {

            }
            else if (role.Equals("A"))//Admin
            {

            }
            else if (role.Equals("S"))//Staff
            {

            }
            btnLogin.Hide();
        }
        private void btnLogin_Click(object sender, EventArgs e) {
            using (var frmLogin = new frmLogin()) {
                frmLogin.ShowDialog();

                string role = frmLogin.Role; // return the role number from frmLogin
                if (role != null) {      //Check if role get from Login form is null because of clicking Cancel button.

                    EnabledFunctionForSpecificRole(role);
                    lbUnsignIn.Visible = false; // hide welcome label if user login successfull.

                }
            }
        }

        private void ContentPanel_SizeChanged(object sender, EventArgs e) {
            if (ucProductMainFrm != null) {
                ucProductMainFrm.Size = ContentPanel.Size;
            }
        }

        private void btnProductFrm_Click(object sender, EventArgs e) {
            //ucProductMainFrm productFrm = new ucProductMainFrm();
            //productFrm.Size = ContentPanel.Size;
            //ContentPanel.Controls.Remove(ucProductFrm);
            //ucProductFrm.Hide();
            //ContentPanel.Controls.Add(productFrm);
        }
        private void HideAllUcControl() {
            foreach (Control ucControl in ContentPanel.Controls) {   //Hide all control before show a specific control
                ucControl.Hide();                                   //for a specific function
            }
        }
    }
}
