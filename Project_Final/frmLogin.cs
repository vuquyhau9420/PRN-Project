using BusinessObject;
using Project_Final.Presenters;
using Project_Final.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Final {
    public partial class frmLogin : Form, ILoginView {
        public string Role { get; set; }

        private LoginPresenter loginPresenter;

        public string Username { get => txtUsername.Text.Trim(); }

        public string Password { get => txtPassword.Text.Trim(); }

        public frmLogin() {
            InitializeComponent();

            loginPresenter = new LoginPresenter(this);
        }

        private void btnSumbit_Click(object sender, EventArgs e) {
            try {
                Staff currentStaff = loginPresenter.Login();
                if (currentStaff == null) {
                    MessageBox.Show("Login Fail");
                }
                else {
                    MessageBox.Show("Login Success");
                    Role = currentStaff.Role;
                }
                this.Dispose();
            }
            catch (ApplicationException ex) {
                MessageBox.Show(ex.Message, "Login Fail");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Dispose();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e) {
            this.Dispose();
        }
    }
}
